using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;

using Newtonsoft.Json;

namespace WarO_CSharp_v2
{
   class ApiResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("card")]
        public int Card { get; set; }
    }
    public class ApiStrategy : IStrategy
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string SCHEME = "http";
        private readonly string HOST = "localhost";
        private readonly string PATH = "waro/strategy";
        private readonly int PORT = 8080;
        private readonly string MODE = "max";

        private readonly string CARDS_PARAM = "cards";
        private string MODE_PARAM = "mode";
        private string PRIZE_CARD_PARAM = "prize_card";
        private string MAX_CARD_PARAM = "max_card";

        public string GetName()
        {
            return Constants.STRATEGY_API;
        }

        public int SelectCard(int prizeCard, List<int> hand, int maxCard)
        {
            var result = -5150;

            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = SCHEME;
            uriBuilder.Host = HOST;
            uriBuilder.Port = PORT;
            uriBuilder.Path = PATH;

            var queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

            queryString.Add(MODE_PARAM, MODE);
            queryString.Add(PRIZE_CARD_PARAM, prizeCard.ToString());
            queryString.Add(MAX_CARD_PARAM, maxCard.ToString());
            foreach (int card in hand)
            {
                queryString.Add(CARDS_PARAM, card.ToString());
            }

            uriBuilder.Query = queryString.ToString();
            Uri uri = uriBuilder.Uri;

            var response = client.GetAsync(uri.ToString()).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                var textReader = new StringReader(responseString);
                var serializer = new JsonSerializer();
                var apiResult = (ApiResult) serializer.Deserialize(textReader, typeof(ApiResult));
                result = apiResult.Card;
                Console.WriteLine($"TRACER ApiStrategy card: {result} msg: {apiResult.Message}");
            }
            else
            {
                Console.Error.WriteLine("TRACER ApiStrategy failed!");
                throw new Exception("ApiStrategy failed");
            }

            return result;
        }
    }
}
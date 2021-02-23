
using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace WarO_CSharp_v2
{
    class JsonDataPlayer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("strategy_name")]
        public string StrategyName { get; set; }

/*
        public override string ToString() {
            return $"name: {Name} strategy: {StrategyName}";
        }
        */
    }
    class JsonDataConfig
    {
        [JsonProperty("num_cards")]
        public int NumCards { get; set; }
        [JsonProperty("num_games")]
        public int NumGames { get; set; }
        [JsonProperty("is_verbose")]
        public bool IsVerbose { get; set; }

        [JsonProperty("players")]
        public List<JsonDataPlayer> players { get; set; }

/*
        public override string ToString() {
            var s = $"# games: {NumGames} # cards: {NumCards} verbose? {IsVerbose}\n";
            foreach (Player p in players)
            {
                s += $"{p}\n";
            }
            return s;
        }
        */
    }
    public class JsonConfig : IConfig
    {
        private JsonDataConfig config;

        public JsonConfig(string jsonFile)
        {
            parseConfig(jsonFile);
        }

        void parseConfig(string jsonFile)
        {
            using (StreamReader file = File.OpenText(jsonFile))
            {
                var serializer = new JsonSerializer();
                config = (JsonDataConfig) serializer.Deserialize(file, typeof(JsonDataConfig));
                // Console.WriteLine($"TRACER {config}");
            }
            Console.WriteLine("TRACER parseConfig => OK");
        }

        public bool IsVerbose()
        {
            return config.IsVerbose;
        }

        public int GetNumCardsPerHand()
        {
            int numPlayers = GetPlayers().Count;
            int numCardsPerHand = GetMaxCard() / (numPlayers + 1);
            return numCardsPerHand;
        }

        public int GetMaxCard()
        {
            return config.NumCards;
        }
        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            var maxCard = config.NumCards;

            foreach (JsonDataPlayer p in config.players)
            {
                var strategy = new Strategies().GetStrategy(p.StrategyName);
                var player = new Player(p.Name, strategy, maxCard);
                players.Add(player);
            }

            return players;
        }

        public override string ToString()
        {
            string result = "\n";
            result += "maxCard: " + GetMaxCard() + "\n";
            foreach (Player player in GetPlayers()) {
                result += player.ToString() + "\n";
            }
            return result;
        }
    }
}

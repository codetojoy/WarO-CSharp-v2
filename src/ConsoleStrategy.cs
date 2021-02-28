using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class ConsoleStrategy : IStrategy
    {
        public string GetName()
        {
            return Constants.STRATEGY_CONSOLE;
        }
        public int SelectCard(int prizeCard, IList<int> hand, int maxCard)
        {
            bool isDone = false;
            string input = "";

            while (!isDone)
            {
                Console.WriteLine("select card: ");
                input = Console.ReadLine();
                IsQuit(input);
                bool isValid = IsValid(input, hand);
                isDone = isValid;

                if (!isValid)
                {
                    Console.Error.WriteLine("illegal choice!");
                }
            }

            int selectedCard = ParseInput(input);
            return selectedCard;
        }

        private void IsQuit(string input)
        {
            if (input.Trim().ToLower() == Constants.CMD_FORCE_QUIT)
            {
                new Runner().Quit();
            }
        }

        private bool IsValid(string input, IList<int> hand)
        {
            bool result = false;

            try
            {
                int cardInput = Int32.Parse(input);
                result = hand.Contains(cardInput);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }

            return result;
        }

        private int ParseInput(string input)
        {
            return Int32.Parse(input);
        }
    }
}

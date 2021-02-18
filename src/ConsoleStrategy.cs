using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class ConsoleStrategy : IStrategy
    {
        public string GetName() {
            return "console";
        }
        public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
            bool isDone = false;
            string input = "";

            while (!isDone) {
                Console.WriteLine("select card: ");
                input = Console.ReadLine();
                bool isValid = IsValid(input, hand);
                isDone = isValid;

                if (!isValid) {
                    Console.Error.WriteLine("illegal choice!");
                }
            }

            int selectedCard = ParseInput(input);
            return selectedCard;
        }

        private bool IsValid(string input, List<int> hand) {
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

        private int ParseInput(string input) {
            return Int32.Parse(input);
        }
    }
}

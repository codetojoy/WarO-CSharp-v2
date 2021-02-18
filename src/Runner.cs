using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            InputLoop();
            /*
            var config = new Config();
            var dealer = new Dealer();
            var table = dealer.Deal(config);
            Console.WriteLine(table.ToString());
            */
        }
        public void InputLoop() {
            bool isDone = false;

            while (!isDone) {
                Console.WriteLine("");
                Console.WriteLine("Show config [s]:");
                Console.WriteLine("New game    [n]:");
                Console.WriteLine("Quit        [q]:\n");
                Console.WriteLine("enter command: ");
                string input = Console.ReadLine().Trim().ToLower();

                switch (input) {
                    case "q":
                        isDone = Quit();
                        break;
                    case "s":
                        ShowConfig();
                        break;
                    case "n":
                        PlayGame();
                        break;
                    default:
                        Console.Error.WriteLine("unrecognized command!");
                        break;
                }
            }
        }

        private bool Quit() {
            Console.WriteLine("Roger copy... bye for now");
            return true;
        }

        private void ShowConfig() {
            var config = new Config();
            Console.WriteLine(config.ToString());
        }

        private void PlayGame() {
            var config = new Config();
            Console.WriteLine("TRACER TODO: play game");
        }

        public string CanaryRepeat(string s, int n) {
            string result = "";
            for (int i = 1; i <= n; i++) {
                result += s;
            }
            return result;
        }
    }
}
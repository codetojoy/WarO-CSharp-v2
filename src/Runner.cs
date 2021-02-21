using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            InputLoop();
        }
        public void InputLoop() {
            while (true) {
                Console.WriteLine("");
                Console.WriteLine("Show config [s]:");
                Console.WriteLine("New game    [n]:");
                Console.WriteLine("Quit        [q]:\n");
                Console.WriteLine("enter command: ");
                string input = Console.ReadLine().Trim().ToLower();

                switch (input) {
                    case Constants.CMD_QUIT:
                        Quit();
                        break;
                    case Constants.CMD_SHOW_CONFIG:
                        ShowConfig();
                        break;
                    case Constants.CMD_NEW_GAME:
                        PlayGame();
                        break;
                    default:
                        Console.Error.WriteLine("unrecognized command!");
                        break;
                }
            }
        }

        public void Quit() {
            Console.WriteLine("Roger copy... bye for now");
            Environment.Exit(0);
        }

        private void ShowConfig() {
            var config = new Config();
            Console.WriteLine(config.ToString());
        }

        private void PlayGame() {
            var config = new Config();
            var dealer = new Dealer();
            var deck = new Deck(config.GetMaxCard());
            var table = dealer.Deal(config, deck);
            var game = new Game();
            game.PlayGame(table, config.IsVerbose());
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
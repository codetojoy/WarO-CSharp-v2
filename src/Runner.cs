using System;
using System.Collections.Generic;

using WarO_CSharp_v2.Config;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("requires config file as arg");
                Environment.Exit(-1);
            }
            InputLoop(args[0]);
        }
        public void InputLoop(string configFile)
        {
            IConfig config = new JsonConfig(configFile);
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Show config [s]:");
                Console.WriteLine("New game    [n]:");
                Console.WriteLine("Quit        [q]:\n");
                Console.WriteLine("enter command: ");
                string input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case Constants.CMD_QUIT:
                        Quit();
                        break;
                    case Constants.CMD_SHOW_CONFIG:
                        ShowConfig(config);
                        break;
                    case Constants.CMD_NEW_GAME:
                        PlayGame(config);
                        break;
                    default:
                        Console.Error.WriteLine("unrecognized command!");
                        break;
                }
            }
        }

        public void Quit()
        {
            Console.WriteLine("Roger copy... bye for now");
            Environment.Exit(0);
        }

        private void ShowConfig(IConfig config)
        {
            Console.WriteLine(config.ToString());
        }

        private void PlayGame(IConfig config)
        {
            var dealer = new Dealer();
            var deck = new Deck(config.GetMaxCard());
            var table = dealer.Deal(config, deck);
            var game = new Game();
            game.PlayGame(table, config.IsVerbose());
        }
    }
}

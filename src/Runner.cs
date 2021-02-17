using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            Config config = new Config();
            List<Player> players = config.GetPlayers();
            Console.WriteLine("TRACER  hello from Runner");
            Console.WriteLine("TRACER num players: " + players.Count);
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
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            var config = new Config();
            var dealer = new Dealer();
            var table = dealer.Deal(config);
            Console.WriteLine(table.ToString());
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
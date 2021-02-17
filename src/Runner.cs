using System;

namespace WarO_CSharp_v2
{
    public class Runner
    {
        public void Run(string[] args)
        {
            Console.WriteLine("TRACER: hello from Runner");
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
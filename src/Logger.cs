using System;

namespace WarO_CSharp_v2
{
    public class Logger
    {
        public static void Log(string msg, bool isVerbose = true)
        {
            if (isVerbose) 
            {
                var threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
                var now = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine($"TRACER ({threadId}) {now} {msg}");
            }
        }
    }
}

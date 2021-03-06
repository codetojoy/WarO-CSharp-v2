﻿using System;

namespace WarO_CSharp_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner();
            try
            {
                runner.Run(args);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"caught exception! msg: {e.Message}");
            }
            Console.WriteLine("Ready.");
        }
    }
}

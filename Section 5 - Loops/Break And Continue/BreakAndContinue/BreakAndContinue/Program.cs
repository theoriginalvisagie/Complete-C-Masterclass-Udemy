﻿using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we Stop");
                    break;
                }
               
            }

            for (int counter = 0; counter < 10; counter++)
            {
                
                if (counter == 3)
                {
                    Console.WriteLine("We skip 3");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}

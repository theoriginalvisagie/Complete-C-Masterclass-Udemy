using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increments by 1 untill 9 is reached
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            //increments by 5 until smaller than 50 reached
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }
            
            //prints out odd numbers between 0 and 20
            for (int counter = 0; counter <=20; counter++)
            {
                if (counter % 2 != 0) 
                {
                    Console.WriteLine(counter);
                }
            }

            Console.Read();
        }
    }
}

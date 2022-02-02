using System;

namespace IfStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's teh temprature like?");
            string temprature = Console.ReadLine();
            int numTemp = int.Parse(temprature);

            if (numTemp < 20)
            {
                Console.WriteLine("Take your coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("It's 10 degrees outside");
            }
            else
            {
                Console.WriteLine("Shorts are enought today");
            }

            //Ineffeciant code
            //runs through all conditions even if one is met

            /*if (numTemp < 20)
            {
                Console.WriteLine("Take your coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("It's 10 degrees outside");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enought today");
            }*/

            Console.Read();
        }
    }
}

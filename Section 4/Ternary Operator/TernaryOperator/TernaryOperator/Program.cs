using System;

namespace TernaryOperator
{
    class Program
    {
        //Simplified version of is statment
        static void Main(string[] args)
        {
            int temprature = -5;
            string stateOfMatter;

            stateOfMatter = temprature < 0 ? "Solid" : "Liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}");

            temprature += 30;
            stateOfMatter = temprature < 0 ? "Solid" : "Liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");

            temprature += 110;
            stateOfMatter = temprature > 100 ? "Gas" : temprature < 0 ? "Solid" : "Liquid";
            Console.WriteLine($"State of matter is {stateOfMatter}");
            Console.ReadKey();
        }
    }
}

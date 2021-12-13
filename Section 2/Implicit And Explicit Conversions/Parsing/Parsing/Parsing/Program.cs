using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";

            string result = myString + mySecondString;

            //Convert string to int
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultTwo = num1 + num2;

            //1513
            Console.WriteLine(result);
            //28
            Console.WriteLine(resultTwo);

            Console.Read();
        }
    }
}

using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implicit Conversion
            //Big to small 
            int num = 123456789;
            long bigNum = num;

            //Explicit Conversion
            double myDouble = 13.75;
            int myInt;
            
            //Cast double to int
            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.Read();

            //type Conversion
            string myString = myDouble.ToString();
            num.ToString();

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}

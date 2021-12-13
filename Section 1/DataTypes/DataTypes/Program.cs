using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            int num1;
            // initialize
            num1 = 13;

            //declare and initialize
            int num2 = 23;


            int sum = num1 + num2;

            // use concatenation
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            //multiple variables in one line
            int num3, num4, num5;

            /*
             * doubles have high precision (more accurate)
             */
            double d1 = 3.1415;
            double d2 = 5.1;

            double dDiv = d1 / d2;

            Console.WriteLine("Double sum is " + dDiv);

            /*
             * Float has low precision (less accurate)
             */
            float f1 = 3.1415f;
            float f2 = 5.1f;

            float fDivf = f1 / f2;

            Console.WriteLine("Float sum is " + fDivf);

        }
    }
}

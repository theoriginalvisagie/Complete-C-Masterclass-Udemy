using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            //Modyfies value of the related value
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {isSunny}");

            //increment operators
            int num = 0;
            num++;

            Console.WriteLine($"num is {num}");
            Console.WriteLine($"num is {num++}");
            // if num++ = only happen in next line(post increment)
            // if ++num = happen in same line(pre increment)
            Console.WriteLine($"num is {++num}");

            //Decrement operators
            int numDec = 3;
            numDec++;

            Console.WriteLine($"num is {numDec}");
            Console.WriteLine($"num is {numDec--}");
            // if num-- = only happen in next line(post decrement)
            // if --num = happen in same line(pre decrement)
            Console.WriteLine($"num is {--numDec}");

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"result is {isLower}");

            //equality operato
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"result is {isEqual}");

            isEqual = num1 != num2;
            Console.WriteLine($"result is {isEqual}");

            //conditional operators
            bool isLowerAndSunny;
            //condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"result is {isLowerAndSunny}");

            //OR
            //condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"result is {isLowerAndSunny}");


            Console.ReadKey();
        }
    }
}

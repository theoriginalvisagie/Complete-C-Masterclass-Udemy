using System;

namespace MethodsWithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(Add(1, 2), Add(3, 4));
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(result);
            Console.WriteLine(Multiply(5,5));
            Console.WriteLine(Divide(25, 5));

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double d1, double d2)
        {
            return d1 / d2;
        }
    }

}

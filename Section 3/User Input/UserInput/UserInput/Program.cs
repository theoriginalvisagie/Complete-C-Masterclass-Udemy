using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number.");
            string num1Input = Console.ReadLine();

            Console.WriteLine("Please enter the second number.");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);
            int result = num1 + num2;

            return result;
        }
    }
}

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize array and length.
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 4;
            grades[2] = 6;
            grades[3] = 13;
            grades[4] = 34;

            Console.WriteLine($"Grade at index 0 {grades[0]}");

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grade at index 0 {grades[0]}");
            Console.ReadKey();

            int[] gradesOfMathsStudentsA = { 20, 30, 20, 40, 50 };

            int[] gradesOfMathsStudentsB = new int[] { 23, 56, 43, 78, 56 };

            Console.WriteLine($"length of gradesOfMathsStudentsA is  {gradesOfMathsStudentsA.Length}");
        }
    }
}

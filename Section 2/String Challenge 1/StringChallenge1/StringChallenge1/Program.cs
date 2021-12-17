using System;

namespace StringChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please type your name and press enter.");

            myName = Console.ReadLine();
            Console.WriteLine($"Upper Case: {myName.ToUpper()}.");
            Console.WriteLine($"Lower Case: {myName.ToLower()}.");
            Console.WriteLine($"Trimmed: {myName.Trim()}.");
            Console.WriteLine($"SubString: {myName.Substring(0, 5)}.");

        }
    }
}

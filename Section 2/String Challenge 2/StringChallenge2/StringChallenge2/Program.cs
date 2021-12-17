using System;

namespace StringChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userSearch;
            Console.WriteLine("Type a string and hit enter.");
            userInput = Console.ReadLine();

            Console.WriteLine("What should we search in the string?");
            userSearch = Console.ReadLine();

            if (userInput.IndexOf(userSearch) > 0) 
            {
                Console.WriteLine($"The index of '{userSearch}' in '{userInput}' is {userInput.IndexOf(userSearch)}.");
            }
            else 
            {
                Console.WriteLine($"Sorry We couldn't find '{userSearch}' inside '{userInput}'");
            }

        }
    }
}

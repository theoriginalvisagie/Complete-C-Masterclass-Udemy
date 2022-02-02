using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            string message = "My first string is " + str;
            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
        }
    }
}
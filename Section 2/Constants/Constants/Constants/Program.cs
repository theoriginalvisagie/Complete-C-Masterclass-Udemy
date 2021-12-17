using System;

namespace Constants
{
    class Program
    {
        //Constants are immutable values which are known at compile time and do not change for
        //the life of the program

        //Constants as Fields
        const double Pi = 3.141592;
        const int weeks = 52, Months = 12;
        const string birthday = "31/03/1996";
        static void Main(string[] args)
        {
            Console.WriteLine($"My Birthday is {birthday}");
        }
    }
}

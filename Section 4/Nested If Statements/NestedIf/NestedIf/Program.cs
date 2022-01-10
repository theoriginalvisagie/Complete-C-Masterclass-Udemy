using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = false;
            string userName;

            Console.WriteLine("Please Enter Your Username");
            userName = Console.ReadLine();

            if (isRegistered && userName != "")
            {
                if (userName.Equals("admin"))
                {
                    Console.WriteLine("Hi there Admin User");
                }
                else {
                    Console.WriteLine("Hi there Registered User");
                }
            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
        }
    }
}

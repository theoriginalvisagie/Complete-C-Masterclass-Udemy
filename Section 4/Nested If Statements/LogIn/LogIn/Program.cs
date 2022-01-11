using System;

namespace LogIn
{
    class Program
    {
        static string userName, password;
        static void Main(string[] args)
        {
            Register();
            LogIn();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please Register a Username.");
            userName = Console.ReadLine();
            Console.WriteLine("Please Create a Password.");
            password = Console.ReadLine();

            Console.WriteLine("You have succesfully registered");
            Console.WriteLine("Please enter your username to login to your account.");
        }

        public static void LogIn()
        {
            if (userName == Console.ReadLine())
            {
                Console.WriteLine($" Welcome {userName}, Please enter your password");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine("You have loged in.");
                }else
                {
                    Console.WriteLine("Incorrect Password entered");
                }
            }else
            {
                Console.WriteLine("Incorrect Username entered");
            }
        }
    }
}

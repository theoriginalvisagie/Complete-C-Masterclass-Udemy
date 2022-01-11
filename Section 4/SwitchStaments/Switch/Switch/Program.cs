using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young");
                    break;
                case 25:
                    Console.WriteLine("YOOOO");
                    break;
                case 35:
                    Console.WriteLine("Very Old");
                    break;
                default:
                    Console.WriteLine("How Old are you?");
                    break;

            }
        }
    }
}

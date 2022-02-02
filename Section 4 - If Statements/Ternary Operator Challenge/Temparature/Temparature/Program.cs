using System;

namespace Temparature
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTemprature = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            Console.WriteLine("Enter the current temprature : ");
            inputValue = Console.ReadLine();

            bool validInteger = int.TryParse(inputValue, out inputTemprature);

            if (validInteger)
            {
                tempMessage = inputTemprature <= 15 ? "It is cold" : (inputTemprature >= 16 && inputTemprature <= 28) ? "It is hot" : "";

                Console.WriteLine(tempMessage);
            }
            else {
                Console.WriteLine("Not a valid temprature");
            }
        }
    }
}

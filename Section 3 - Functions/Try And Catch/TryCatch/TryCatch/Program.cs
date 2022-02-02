using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            string userInput = Console.ReadLine();

            int num1 = 5, num2 = 0;

            try
            {
                int Result = num1 / num2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero!");
            }

            //try to see if code inside will work
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, number was to long to convert to int");
            }
            //Executes after all try and catches has finished
            finally
            {
                Console.WriteLine("This is called when all try catch are done");
            }
            Console.ReadKey();
        }
    }
}

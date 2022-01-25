using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }


            int counter2 = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Hit enter to increase by one " + " +enter if you want to finish" );
                enteredText = Console.ReadLine();
                counter2++;
                Console.WriteLine($"Current people count {counter2}");
            }
            Console.WriteLine($"{counter2} people in the bus. Press enter to exit");
            Console.Read();
        }
    }
}

using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 15;

            //do
            //{
                //Console.WriteLine(counter);
               // counter++;
            //} while (counter < 15);

            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Enter name of a friend.");
                string nameOfFriend = Console.ReadLine();
                int currentLenght = nameOfFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfFriend;
            } while (lenghtOfText < 20);

            Console.WriteLine($"Thanks, that's enough {wholeText}" );
            Console.Read();

        }
    }
}

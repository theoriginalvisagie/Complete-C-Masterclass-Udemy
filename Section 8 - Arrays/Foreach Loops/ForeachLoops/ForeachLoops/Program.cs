using System;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            // Assing index to value
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            // Read indes j value
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"Element {j} is {j}");
            }

            // Foreach loop
            int cnt = 0;
            foreach (int k in nums)
            {
                Console.WriteLine($"Element {cnt} is {k}");
                cnt++;
            }

            //Challenge
            string[] myFriends = { "Sam", "Dylan", "Marc", "Tiaan", "Rouxmon" };

            foreach (string str in myFriends)
            {
                Console.WriteLine($"Good Day {str}, how are you?");
            }

            Console.ReadKey();
        }
    }
}

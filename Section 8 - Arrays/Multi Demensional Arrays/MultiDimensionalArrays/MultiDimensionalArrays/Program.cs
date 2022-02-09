using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 2d array
            string[,] matrix;

            // 3D Array
            int[,,] threeD;

            // 2D array
            int[,] array2D = new int[,]
            {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 }
            };

            Console.WriteLine($"Central vale is {array2D[1,1]}");
            //Console.ReadKey();

            string[,,] array3D = new string[,,]
            {
                {
                    { "000","001" },
                    { "010","011" },
                    { "Hi there","Wat's up?" }

                },
                {
                    { "100", "101" },
                    { "110","111" },
                    { "Another one","Last entry" }
                }
            };

            Console.WriteLine($"The vale is {array3D[1, 1, 1]}");

            string[,] arrayString = new string[3, 2] { { "One", "Two" }, { "Three", "Four" }, { "Five", "Six" } };
            arrayString[1, 1] = "Chicken";

            Console.WriteLine($"The new vale is {arrayString[1, 1]}");

            //Returns dimensions of array
            int dimensions = arrayString.Rank;

            Console.WriteLine($"The array as {dimensions} dimensions");

            int[,] arrayNew2D = { { 1, 2 }, { 3, 4 } };

            Console.ReadKey();
        }
    }
}

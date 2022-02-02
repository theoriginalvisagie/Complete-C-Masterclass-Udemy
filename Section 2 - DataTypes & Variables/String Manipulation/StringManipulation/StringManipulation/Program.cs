using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Christiaan";
            string job = "Developer";

            //1. Concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " and my age is " + age);

            //2. String formatting
            //String formatting uses the index
            //{0} used to define what variable after first comma needs to appear in it position.
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} and my age is {1}, I am a {2}", name, age, job);

            //3. String Interpolation
            //Uses $ at the start of string to allow us to uses our variables directky in the string
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} and my age is {age}. I am a {job}");

            //4. Verbatim Strings.
            //Vrbatim strings  start with @ and tells compiler to take the string literally and ignore
            //any spaces and escape chars like /n
            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum");

            // Usecase to print out file path and not have to include \\ for path.
            Console.WriteLine(@"C:\users\Visagie\documents\Test.pdf");

        }
    }
}

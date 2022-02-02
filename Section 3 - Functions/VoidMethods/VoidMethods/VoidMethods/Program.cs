using System;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteString("I am called from WriteString");
            Console.Read();
        }

        //<access modifier><(static)><return type><method name>(param1, param2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteString(string myText) 
        {
            Console.WriteLine(myText);
        }
    }
}

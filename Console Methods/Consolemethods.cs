using System;

namespace ConsoleMethods
{
    class Program
    {
        ///<summary>
        ///System Methods available and their uses
        ///</summary>        
        static void Main(string[] args)
        {
            //Prints and keeps cursor on same line.
            Console.Write("Hello World!");

            //Prints and moves cursor to next line.
            Console.WriteLine("Hello World!");

            //Takes single inout of type string and returns ASCII value
            Console.Read();

            //Reads input from user Returns input as Output
            Console.ReadLine();

            //Takes input of type string and returns the key info
            Console.ReadKey();
        }
    }
}

//Link to Console Methods Docs
//https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1#System_Console_WriteLine_System_String_
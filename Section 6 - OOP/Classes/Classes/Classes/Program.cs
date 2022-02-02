using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of class
            // An Instance of Human
            Human me = new Human();
            // aAccess public variable
            me.firstName = "Christiaan";
            me.lastName = "Visagie";
            // Call Methods from class
            me.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "Micael";
            michael.lastName = "Stroh";
            michael.IntroduceMyself();

            Console.ReadKey();
        }
    }
}

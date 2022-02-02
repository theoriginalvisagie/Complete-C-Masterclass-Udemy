using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("Christiaan", "Visagie","green","26");
            me.IntroduceMyself();

            Human dylan = new Human("Dylan", "Roodt", "brown", "26");
            dylan.IntroduceMyself();

            Human sam = new Human("Sam", "Monty", "blue", "1");
            sam.IntroduceMyself();
        }
    }
}

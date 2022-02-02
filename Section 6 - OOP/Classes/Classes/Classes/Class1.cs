using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Human
    {
        // Member Variable
        // public -> accessable globaly
        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine($"HI, I'm {firstName} {lastName}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Human
    {
        // Variables can be private if contrustor is present.
        private string firstName;
        private string lastName;
        private string eyeColor;
        private string age;

        // Create constructor.
        public Human(string firstName, string lastName, string eyeColor, string age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            if (age == "1")
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName} my eyecolor is {eyeColor} and I am {age} year old.");
            }
            else 
            {
                Console.WriteLine($"Hi I'm {firstName} {lastName} my eyecolor is {eyeColor} and I am {age} years old.");
            }
            
        }
    }
}

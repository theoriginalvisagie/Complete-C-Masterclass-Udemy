using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalizers
{
    class Memebrs
    {
        // Memebers - private
        private string memberName;
        private string jobTitle;
        private int salary;

        // Member - public
        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Public memeber Method - can be called from othe classes
        public void Introducing(bool isFirend)
        {
            if (isFirend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName} and my job title is {jobTitle} and I am {age} years old.");
            }
        }

        public void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // Member constructor
        public Members()
        {
            age = 30;
            memberName = "Sally";
            jobTitle = "Developer";
            Console.WriteLine("Object Created!");
        }

        // Destructor
        ~Members()
        {
            Console.WriteLine("Destruction of members");
        }
    }
}

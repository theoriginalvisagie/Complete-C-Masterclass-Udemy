using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        // Memeber Variables     
        private int lenght;
        // Unsafe Code
        public int height;
        public int width;
        public int volume;

        // Setter
        public void SetLength(int newlength)
        {
            if (lenght < 0)
            {
                throw new Exception("Lenght is less than 0");
            }
            else 
            {
                this.lenght = newlength;
            }
           
        }

        public int GetVolume()
        {
            return this.height * this.lenght * this.width;
        }
        // Only this class
        // and classes that inherent
        /*private void SetLength(int newlength)
        {
            this.lenght = newlength;
        }*/

        public int GetLenth() 
        {
            return this.lenght;
        }

        public void DisplayInfo()
        {
            volume = lenght * width * height;
            Console.WriteLine($" Lenght is {lenght}, width is {width}, height is {height} and the volume is {volume}");
        }
    }
}

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

        public void SetLength(int newlength)
        {
            this.lenght = newlength;
        }

        public void DisplayInfo()
        {
            volume = lenght * width * height;
            Console.WriteLine($" Lenght is {lenght}, width is {width}, height is {height} and the volume is {volume}");
        }
    }
}

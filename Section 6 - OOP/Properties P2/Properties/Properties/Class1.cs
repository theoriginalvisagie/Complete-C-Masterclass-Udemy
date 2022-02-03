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
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }

        // Properties
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return this.height * this.lenght * this.Width;
            }
        }

        public Box(int length, int width, int height)
        {
            this.lenght = lenght;
            this.height = height;
            Width = width;
        }

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
            return this.height * this.lenght * this.Width;
        }

        public int GetLenth() 
        {
            return this.lenght;
        }

        public void DisplayInfo()
        {
            //volume = lenght * width * height;
            Console.WriteLine($" Lenght is {lenght}, width is {Width}, height is {height} and the volume is {Volume}");
        }
    }
}

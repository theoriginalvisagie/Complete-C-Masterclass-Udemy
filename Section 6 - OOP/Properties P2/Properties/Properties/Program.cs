using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,5,4);

            //box.SetLength(4);
            //box.Width = 5;
            //box.Height = -4;
            //Console.WriteLine($"The length is {box.GetLenth()}");
            //Console.WriteLine($"The volume is {box.GetVolume()}");
            //Console.WriteLine($"The width is {box.Width}");
            box.DisplayInfo();
        }
    }
}

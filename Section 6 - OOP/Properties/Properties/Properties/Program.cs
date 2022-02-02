using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            // Can't set lenght due to privacy
            //box.lenght = 4;
            box.SetLength(4);
            box.width = 4;
            box.height = 4;

            box.DisplayInfo();
        }
    }
}

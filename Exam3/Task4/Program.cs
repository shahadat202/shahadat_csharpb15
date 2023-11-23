using System;

namespace Task4
{
    class program
    {
        static void Main(string[] args)
        {
            Cannon cannon = new Cannon();

            cannon.TakePhoto(100, 100);
            cannon.TakePhoto("Z5", "Black");

        }
    }
}
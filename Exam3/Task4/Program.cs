using System;

namespace Task4
{
    class program
    {
        static void Main(string[] args)
        {
            Cannon cannon = new Cannon("A15");
            Console.WriteLine(cannon.Model);

            Cannon cannon2 = new Cannon("Z5", "Black");

            cannon.TakePhoto(100, 100);

            cannon.TakePhoto("S10", "Gray");
        }
    }
}
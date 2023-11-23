using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Cannon : Camera
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public void TakePhoto(int width, int height)
        {
            Console.WriteLine($"Took photo of size: {width}x{height}");
        }
        public void TakePhoto(string model, string color)
        {
            Console.WriteLine($"Camera model is- '{model}' and color is- '{color}'");
        }
    }
}

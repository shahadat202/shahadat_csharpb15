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

        public Cannon(string model)
        {
            Model = model;
        }
        public Cannon(string model, string color)
        {
            Model = model;
            Color = color;
            Console.WriteLine($"Camera Model is- '{model}' and Color is- '{color}'");
        }
        public void TakePhoto(int width, int height)
        {
            Console.WriteLine($"Took photo of size: {width}x{height}");
        }

        public void TakePhoto(string model, string color)
        {
            Console.WriteLine($"Camera Model is- '{model}' and Color is- '{color}'");
        }

    }
}

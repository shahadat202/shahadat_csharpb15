using System;
using System.Collections.Generic;

namespace TaskOne_22_7_50
{
    class program
    {
        static void Main(string[] args)
        {
            string[] intpu = Console.ReadLine().Split();
            int a = int.Parse(intpu[0]);
            int b = int.Parse(intpu[1]);
            int c = int.Parse(intpu[2]);

            int x = a / b;
            a %= b;

            Console.Write(x);
            Console.Write('.');

            a *= 10;
            for (int i = 0; i < c; i++)
            {
                Console.Write(a / b);
                a = (a % b) * 10;
            }
        }
    }
}
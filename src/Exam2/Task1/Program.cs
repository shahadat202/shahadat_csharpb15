using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace task
{
    class program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char c = '*';

            for (int i = 1; i <= n; i+=2)
            {
                int space = (n-i) / 2;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(c);
                }
                for (int j = 0; j < space; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            for (int i = n - 2; i >= 1; i -= 2)
            {
                int space = (n - i) / 2;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(c);
                }
                for (int j = 0; j < space; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
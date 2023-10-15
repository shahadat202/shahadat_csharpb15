using System;
using System.Collections.Generic;
namespace A_Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> v = new List<int>();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                sum = (sum - a) + b;
                v.Add(sum);
            }
            int mx = v.Max();
            Console.WriteLine(mx);
        }
    }
}
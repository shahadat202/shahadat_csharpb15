using System;
using System.Collections.Generic;
namespace practice
{
    class program
    {
        static void solve()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> d = new List<int>();
            List<int> a = new List<int>();

            string[] dInput = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                d.Add(int.Parse(dInput[i]));
            }
            a.Add(d[0]);
            for (int i = 1; i < n; i++)
            {
                if (d[i] > 0 && a[i - 1] >= d[i])
                {
                    Console.WriteLine(-1);
                    return;
                }
                a.Add(a[i - 1] + d[i]);
            }
            Console.WriteLine(string.Join(" ", a));
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                solve();
                t--;
            }
        }
    }
}
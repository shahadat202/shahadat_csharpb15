using System.Collections;
using System.Collections.Generic;

class Program
{
    static void solve()
    {
        string[] s = Console.ReadLine().Split();
        int row = int.Parse(s[0]);
        int col = int.Parse(s[1]);

        char[,] chars = new char[row, col];

        for (int i = 0; i < row; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < col; j++)
            {
                chars[i, j] = char.Parse(input[j]);
            }
        }

        int mx = 0;
        for (int i = 0; i < row; i++)
        {
            int cnt = 1;
            for (int j = 0; j < col-1; j++)
            {
                if (chars[i, j] == chars[i, j + 1])
                {
                    cnt++;
                    mx = Math.Max(mx, cnt);
                }
                else
                {
                    cnt = 1;
                }
            }
            mx = Math.Max(mx, cnt);
        }
        Console.WriteLine(mx);
    }
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            solve();
        }
    }
}
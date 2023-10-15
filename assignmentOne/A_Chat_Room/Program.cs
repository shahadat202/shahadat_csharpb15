using System;

class A_Chat_Room
{
    static void Main()
    {
        string s = Console.ReadLine();
        string hello = "hello";

        int i = 0, j = 0;
        while (i < s.Length && j < hello.Length)
        {
            if (s[i] == hello[j])
            {
                j++;
            }
            i++;
        }

        if (j == hello.Length)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

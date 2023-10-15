using System.Runtime.Intrinsics.X86;

namespace A_Stones_On_The_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();

            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1]) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
namespace A_Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt = 1, ans = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    cnt++;
                }
                else
                {
                    ans = Math.Max(ans, cnt);
                    cnt = 1;
                }
            }
            ans = Math.Max(ans, cnt);
            if (ans >= 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
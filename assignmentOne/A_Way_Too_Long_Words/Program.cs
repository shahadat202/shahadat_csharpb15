namespace A_Way_Too_Long_Words
{
    internal class Program
    {
        static void solve()
        {
            string s = Console.ReadLine();
            if (s.Length <= 10)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine($"{s[0]}{s.Length - 2}{s[^1]}");
            }
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
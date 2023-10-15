namespace A_Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int cnt = 0;
            while (t > 0)
            {
                string s = Console.ReadLine();
                if (s[1] == '+') cnt++;
                else cnt--;
                t--;
            }
            Console.WriteLine(cnt);
        }
    }
}
namespace A_HQ9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool found = false;

            foreach (char c in s)
            {
                if (c == 'H' || c == 'Q' || c == '9')
                {
                    found = true;
                    break;
                }
            }
            if (found)
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
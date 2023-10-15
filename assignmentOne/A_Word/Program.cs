namespace A_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int low = 0, up = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    up++;
                }
                else low++;
            }
            if (up > low)
            {
                s = s.ToUpper();
            }
            else
            {
                s = s.ToLower();
            }
            Console.WriteLine(s);
        }
    }
}
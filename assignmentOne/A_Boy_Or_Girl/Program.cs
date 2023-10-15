namespace A_Boy_Or_Girl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            HashSet<char> set = new HashSet<char>();

            foreach (char c in a)
            {
                set.Add(c);
            }
            if (set.Count % 2 == 1)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }
        }
    }
}
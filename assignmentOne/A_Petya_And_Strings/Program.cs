namespace A_Petya_And_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            a = a.ToLower();
            b = b.ToLower();

            int result = string.Compare(a, b);

            if (result < 0)
            {
                Console.WriteLine(-1);
            }
            else if (result == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
namespace A_String_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y')
                {
                    continue;
                }
                else
                {
                    Console.Write($".{s[i]}");
                }
            }
        }
    }
}
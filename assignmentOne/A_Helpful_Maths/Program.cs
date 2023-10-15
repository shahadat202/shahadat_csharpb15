namespace A_Helpful_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length - 1; i += 2)
            {
                for (int j = 0; j < chars.Length - 1; j += 2)
                {
                    if (chars[j] > chars[j + 2])
                    {
                        char temp = chars[j];
                        chars[j] = chars[j + 2];
                        chars[j + 2] = temp;
                    }
                }
            }
            string result = new string(chars);
            Console.WriteLine(result);
        }
    }
}
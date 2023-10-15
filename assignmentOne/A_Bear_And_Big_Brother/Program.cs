namespace A_Bear_And_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b;
            string[] input = Console.ReadLine().Split();
            l = int.Parse(input[0]);
            b = int.Parse(input[1]);

            int cnt = 0;
            while (l <= b)
            {
                l *= 3;
                b *= 2;
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
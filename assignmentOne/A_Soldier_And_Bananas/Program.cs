namespace A_Soldier_And_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, n, w;
            string[] input = Console.ReadLine().Split();
            k = int.Parse(input[0]);
            n = int.Parse(input[1]);
            w = int.Parse(input[2]);

            int sum = 0;
            for (int i = 1; i <= w; i++)
            {
                sum += (i * k);
            }
            if (sum <= n)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sum - n);
            }
        }
    }
}
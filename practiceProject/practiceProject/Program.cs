namespace practiceProject
{
    class program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine($"{n} is less than 3");
                    break;
                case 1:
                    Console.WriteLine($"{n} is less than 3");
                    break;
                case 2:
                    Console.WriteLine($"{n} is less than 3");
                    break;
                case 3:
                    Console.WriteLine($"{n} is equal to 3");
                    break;
                default: 
                    Console.WriteLine($"{n} is greater than 3");
                    break;
            }
        }
    }
}
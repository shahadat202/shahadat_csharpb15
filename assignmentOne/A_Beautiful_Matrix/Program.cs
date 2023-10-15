namespace A_Beautiful_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            int row = -1, col = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        row = i + 1;
                        col = j + 1;
                        break;
                    }
                }
            }
            int moves = Math.Abs(col - 3) + Math.Abs(row - 3);
            Console.WriteLine(moves);
        }
    }
}
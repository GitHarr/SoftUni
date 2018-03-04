namespace p02.DiagonalDifference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[][] matrix = new long[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
            }

            long primeDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                primeDiagonal += matrix[row][row];
            }

            long secondDiagonal = 0;

            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                secondDiagonal += matrix[row][col];
            }

            Console.WriteLine(Math.Abs(primeDiagonal - secondDiagonal));
        }
    }
}

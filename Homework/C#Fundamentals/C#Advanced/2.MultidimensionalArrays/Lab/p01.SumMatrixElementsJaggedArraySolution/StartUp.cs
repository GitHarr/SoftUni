namespace p01.SumMatrixElementsJaggedArraySolution
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSizes[0])][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int maxSum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    maxSum += matrix[row][col];
                    //maxSum += matrix[row].Sum();    ->   only possible with Jagged array[][]
                }
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(maxSum);
        }
    }
}

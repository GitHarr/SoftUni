namespace p01.MatrixOfPalindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            string[][] matrix = new string[rows][];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new string[cols];

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    var str = (alphabet[rowIndex]).ToString() + (alphabet[rowIndex + colIndex]).ToString()
                        + (alphabet[rowIndex]).ToString();
                    matrix[rowIndex][colIndex] = str;
                }
            }

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    Console.Write(matrix[rowIndex][colIndex] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}

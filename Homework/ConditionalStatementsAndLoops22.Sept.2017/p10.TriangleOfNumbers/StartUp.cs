﻿namespace p10.TriangleOfNumbers
{
    using System;

   public class StartUp
    {
      public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
        
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

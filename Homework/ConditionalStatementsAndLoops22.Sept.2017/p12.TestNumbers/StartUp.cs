namespace p12.TestNumbers
{
    using System;

   public class StartUp
    {
       public static void Main()
        {
            int numN = int.Parse(Console.ReadLine());
            int numM = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int result = 0;
            int totalSum = 0;
            int count = 0;

            for (int i = numN; i >= 1; i--)
            {
                for (int j = 1; j <= numM; j++)
                {
                    result = 3 * (i * j);
                    totalSum += result;
                    count++;

                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}

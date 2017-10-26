namespace p11.EqualSums
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFoundEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    isFoundEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFoundEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}

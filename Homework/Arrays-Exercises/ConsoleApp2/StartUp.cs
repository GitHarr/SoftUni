namespace p01.LargestCommonEnd
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count1++;
                }
                else
                {
                    break;
                }
            }

            for (int i = Math.Min(firstArr.Length, secondArr.Length) - 1; i >= 0; i--)
            {
                int arrDiff = Math.Abs(firstArr.Length - secondArr.Length);

                try
                {
                    if (secondArr[i] == (firstArr[i + arrDiff]))
                    {
                        count2++;
                    }
                    else
                    {
                        break;
                    }
                }

                catch (Exception)
                {

                    break;
                }
            }

            if (!(count1 == 0 && count2 == 0))
            {
                Console.WriteLine(Math.Max(count1, count2));
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

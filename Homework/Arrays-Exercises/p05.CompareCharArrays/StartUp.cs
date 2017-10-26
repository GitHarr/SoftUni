namespace p05.CompareCharArrays
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var minLenght = Math.Min(firstArr.Length, secondArr.Length);
            bool isFirst = false;

            for (int i = 0; i < minLenght; i++)
            {
                var index1 = (int)firstArr[i];
                var index2 = (int)secondArr[i];

                if (index1 <= index2)
                {
                    isFirst = true;
                }

                else
                {
                    break;
                }
            }

            if (isFirst == true && minLenght == firstArr.Length)
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }

            else
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));
            }
        }
    }
}

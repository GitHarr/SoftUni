namespace p05.CompareCharArrays
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
            var lineOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var lineTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var minLenght = Math.Min(lineOne.Length, lineTwo.Length);
            bool isFirst = false;

            for (int i = 0; i < minLenght; i++)
            {
                var index1 = (int)lineOne[i];
                var index2 = (int)lineTwo[i];

                if (index1 <= index2)
                {
                    isFirst = true;
                }

                else
                {
                    break;
                }
            }

            if (isFirst == true && minLenght == lineOne.Length)
            {
                Console.WriteLine(string.Join("", lineOne));
                Console.WriteLine(string.Join("", lineTwo));
            }

            else
            {
                Console.WriteLine(string.Join("", lineTwo));
                Console.WriteLine(string.Join("", lineOne));
            }
        }
    }
}

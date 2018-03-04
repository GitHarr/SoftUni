namespace p04.MaxSequenceOfEqualElements
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt");

            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

            File.Delete("output.txt");

            int maxnumbers = 0;
            int count = 1;
            int maxcount = 1;
            int pos = 0;
            while (pos < numbers.Count - 1)
            {

                if (numbers[pos] == numbers[pos + 1])
                {
                    count++;

                    if (count > maxcount)
                    {
                        maxcount = count;
                        maxnumbers = numbers[pos];
                    }

                }
                else
                {
                    count = 1;
                }
                pos++;
                if (maxcount == 1)
                {
                    maxnumbers = numbers[0];
                }
            }
            for (int i = 0; i < maxcount; i++)
            {
                var output = $"{maxnumbers}" + " ";
                File.AppendAllText("output.txt", output);
            }
        }
    }
}

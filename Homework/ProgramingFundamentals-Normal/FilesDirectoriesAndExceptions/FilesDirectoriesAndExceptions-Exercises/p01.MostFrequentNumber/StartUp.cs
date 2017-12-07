namespace p01.MostFrequentNumber
{

    using System.IO;
 
    public class StartUp
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input.txt");

            string[] line = numbers.Split(' ');

            File.Delete("output.txt");

            int bestCount = 0;
            string mostFrequentNumber = line[0];

            for (int i = 0; i < line.Length; i++)
            {
                int counter = 0;
             
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[i] == line[j])
                    {
                        counter++;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    mostFrequentNumber = line[i];
                }
            }

            File.AppendAllText("output.txt", mostFrequentNumber);
        }
    }
}

namespace p03.EqualSums
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input.txt");
          
            string[] line = numbers.Split(' ');

            File.Delete("output.txt");

            int[] opit = new int[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                opit[i] = int.Parse(line[i]);
            }

            bool isFoundEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = opit.Take(i).ToArray();
                int[] rightSide = opit.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    isFoundEqualSums = true;
                    string result = i.ToString();
                    File.AppendAllText("output.txt", result);
                    break;
                }
            }

            if (!isFoundEqualSums)
            {
                File.AppendAllText("output.txt", "no");
            }
        }
    }
}

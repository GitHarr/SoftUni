namespace p01.AnonymousThreat
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
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();
             
            while (input != "3:1")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex >= elements.Count)
                { 
                    endIndex = elements.Count - 1;
                }

                switch (command)
                {
                    case "merge":

                        StringBuilder sb = new StringBuilder();

                        for (int i = startIndex; i <=  endIndex; i++)
                        {
                            sb.Append(elements[i]);
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }

                          
                        elements.Insert(startIndex, sb.ToString());

                        break;

                    case "divide":
                        int startIndexDivide = int.Parse(commands[1]);
                        int partitionsCount = int.Parse(commands[2]);

                        List<string> result = DivideEquall(elements[startIndexDivide], partitionsCount);

                        elements.RemoveAt(startIndexDivide);
                        elements.InsertRange(startIndexDivide, result);

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static List<string> DivideEquall(string word, int divide)
        {
            List<string> result = new List<string>();

            int partitionsCount = word.Length / divide;

            while (word.Length >= partitionsCount)
            {
                string element = word.Substring(0, partitionsCount);
                result.Add(element);
                word = word.Substring(partitionsCount);
            }

            result.Add(word);

            if (result.Count == divide)
            {
                return result;
            }

            else
            {

                string concatEl = "";
                concatEl += result[result.Count - 2];
                concatEl += result[result.Count - 1];

                result.Remove(result[result.Count - 1]);
                result.Remove(result[result.Count - 1]);

                result.Add(concatEl);

                return result;
            }
        }
    }
}

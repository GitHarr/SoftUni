namespace p02.LineNumbers
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("Input.txt");

            var numberedLines = lines.Select((line, i) => $"{i + 1}. {line}");

            File.WriteAllLines("output.txt", numberedLines);
        }
    }
}
    
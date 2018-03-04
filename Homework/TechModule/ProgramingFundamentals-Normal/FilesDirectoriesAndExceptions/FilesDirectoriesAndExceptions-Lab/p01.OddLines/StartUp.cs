namespace p01.OddLines
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("Input.txt");

            //File.Delete("odd-lines.txt");

            //for (int i = 1; i < lines.Length; i += 2)
            //{
            //    File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            //}

            string[] oddLines = lines.Where((line, i) => i % 2 == 1).ToArray();
            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}

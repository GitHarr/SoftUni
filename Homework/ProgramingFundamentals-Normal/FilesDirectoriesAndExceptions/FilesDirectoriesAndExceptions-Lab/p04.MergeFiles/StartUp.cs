namespace p04.MergeFiles
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstLines = File.ReadAllLines("FileOne.txt");
            string[] secondLines = File.ReadAllLines("FileTwo.txt");

            string[] output = new string[firstLines.Length + secondLines.Length];

            for (int i = 0; i < firstLines.Length; i++)
            {
                output[i] = firstLines[i] + Environment.NewLine + secondLines[i];
            }

            File.WriteAllLines("merged.txt", output);
        }
    }
}


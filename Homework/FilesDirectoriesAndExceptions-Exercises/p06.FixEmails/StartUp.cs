namespace p06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
   
    public class StartUp
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");

            File.Delete("output.txt");

            for (int i = 0; i < lines.Length; i+=2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }

                var output = $"{name} -> {email}" + Environment.NewLine;

                File.AppendAllText("output.txt", output);
            }
        }
    }
}

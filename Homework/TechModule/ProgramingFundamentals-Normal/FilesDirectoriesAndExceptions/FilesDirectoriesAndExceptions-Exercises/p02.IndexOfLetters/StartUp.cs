namespace p02.IndexOfLetters
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] alphabet = new string[]
            {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };

            File.Delete("output.txt");

            string input = File.ReadAllText("input.txt");

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (input[j].ToString().Contains(alphabet[i]))
                    {
                        var output = $"{input[j]} -> {i}" + Environment.NewLine;
                        File.AppendAllText("output.txt", output);
                    }
                }
            }
        }
    }
}

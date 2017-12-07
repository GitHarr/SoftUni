namespace p04.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
           

            Dictionary<string, string> allMessages = new Dictionary<string, string>();

            while (true)
            {
                string messageLine = Console.ReadLine();

                if (messageLine == "Over!")
                {
                    break;
                }

                int n = int.Parse(Console.ReadLine());

                var messageRegex = new Regex(@"^([0-9]+)([a-zA-Z]{" + $"{n}" + @"})(" + "[^a-zA-Z]*" + ")$");
                var nRegex = new Regex(@"^[0-9]+$");

                var nMatch = n.ToString();

                var messageMatch = messageRegex.Match(messageLine);
                var secondLineMatch = nRegex.Match(nMatch);

                if (!(messageMatch.Success && secondLineMatch.Success))
                {
                    continue;
                }
                
                var firstPartIndexes = messageMatch.Groups[1].Value;
                var message = messageMatch.Groups[2].Value;
                var secondPartIndexes = messageMatch.Groups[3].Value;

                var indexes = string.Concat(firstPartIndexes, secondPartIndexes)
                    .ToCharArray()
                    .Where(char.IsDigit)
                    .ToArray();

                StringBuilder sb = new StringBuilder();
                foreach (var index in indexes)
                {
                    int indexInInt = (int)char.GetNumericValue(index);

                    if (indexInInt >= 0 && indexInInt < message.Length)
                    {
                        sb.Append(message[indexInInt]);
                    }

                    else
                    {
                        sb.Append(" ");
                    }
                }

                if (!allMessages.ContainsKey(message))
                {
                    allMessages.Add(message, sb.ToString());
                }
            }

            foreach (var message in allMessages)
            {
                Console.WriteLine($"{message.Key} == {message.Value}");
            }
        }
    }
}

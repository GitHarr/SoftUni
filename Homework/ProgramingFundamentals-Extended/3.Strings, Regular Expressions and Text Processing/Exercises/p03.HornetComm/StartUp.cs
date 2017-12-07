namespace p03.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string privateMessageRegex = "^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastRegex = "^([^0-9\n]+) <-> ([A-Za-z0-9]+)$";

            List<string> messages = new List<string>();
            List<string> broadcast = new List<string>();

            while (input != "Hornet is Green")
            {
                var privateMessageMatch = Regex.Match(input, privateMessageRegex);
                var broadcastMatch = Regex.Match(input, broadcastRegex);

                if (privateMessageMatch.Success)
                {
                    string recipientCode = privateMessageMatch.Groups[1].ToString();
                    recipientCode = string.Join("", recipientCode.ToCharArray().Reverse().ToArray());
                    messages.Add(recipientCode + " -> " + privateMessageMatch.Groups[2].ToString());
                }

                if (broadcastMatch.Success)
                {
                    string frequency = broadcastMatch.Groups[2].ToString();
                    string frequencyResult = "";
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }

                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }

                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                    }

                    broadcast.Add(frequencyResult + " -> " + broadcastMatch.Groups[1]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }

            else
            {
                broadcast.ForEach(e => Console.WriteLine(e));
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }

            else
            {
                messages.ForEach(e => Console.WriteLine(e));
            }
        }
    }
}

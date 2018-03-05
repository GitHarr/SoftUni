using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _3._Word_Count
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> wordsAndCount = new Dictionary<string, int>();
            List<string> listOfWordsToCheck = new List<string>();

            using (var wordsReader = new StreamReader(@"..\words.txt"))
            {
                string word;

                while ((word = wordsReader.ReadLine()) != null)
                {
                    listOfWordsToCheck.Add(word.ToLower());
                }

                using (var textReader = new StreamReader(@"..\text.txt"))
                {
                    string line;
                    while ((line = textReader.ReadLine()) != null)
                    {
                        var lineToCheck = line
                            .ToLower()
                            .Split(" ,.-!:?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                        foreach (var w in listOfWordsToCheck)
                        {
                            if (lineToCheck.Contains(w))
                            {
                                for (int i = 0; i < lineToCheck.Length; i++)
                                {
                                    if (lineToCheck[i] == w)
                                    {
                                        if (!wordsAndCount.ContainsKey(w))
                                        {
                                            wordsAndCount.Add(w, 0);
                                        }
                                        wordsAndCount[w] += 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }


            using (var writer = new StreamWriter("result.txt"))
            {
                foreach (var w in wordsAndCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{w.Key} - {w.Value}");
                }
            }
        }
    }
}

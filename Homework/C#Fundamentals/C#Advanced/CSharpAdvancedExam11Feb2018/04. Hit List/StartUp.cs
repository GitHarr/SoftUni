using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hit_List
{
    public class StartUp
    {
        public static void Main()
        {
            var allInfo = new Dictionary<string, Dictionary<string, string>>();

            int targetIndex = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end transmissions")
            {
                var tokens = command.Split("=;:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];

                if (!allInfo.ContainsKey(name))
                {
                    allInfo[name] = new Dictionary<string, string>();
                }

                for (int i = 1; i < tokens.Length; i+=2)
                {
                    string key = tokens[i];
                    string value = tokens[i + 1];

                    if (!allInfo[name].ContainsKey(key))
                    {
                        allInfo[name].Add(key, value);
                    }

                    allInfo[name][key] = value;
                }

                command = Console.ReadLine();
            }

            var killCommand = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

            var nameToKill = killCommand[1];
            int countIndex = 0;

            Console.WriteLine($"Info on {nameToKill}:");

            foreach (var info in allInfo[nameToKill].OrderBy(x => x.Key))
            {
                int keyLength = info.Key.Length;
                int valueLength = info.Value.Length;

                countIndex += keyLength + valueLength;

                Console.WriteLine($"---{info.Key}: {info.Value}");
            }

            Console.WriteLine($"Info index: {countIndex}");

            if (countIndex >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }

            else
            {
                int diff = targetIndex - countIndex;

                Console.WriteLine($"Need {diff} more info.");
            }
        }
    }
}

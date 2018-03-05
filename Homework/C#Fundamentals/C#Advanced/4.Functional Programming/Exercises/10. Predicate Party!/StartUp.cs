using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _10._Predicate_Party_
{
    public class StartUp
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                names = ParseCommand(command, names);
            }

            if (names.Count > 0)
            {
                string result = string.Join(", ", names);
                Console.WriteLine($"{result} are going to the party!");
            }

            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }

        private static List<string> ParseCommand(string command, List<string> names)
        {
            var tokens = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string doubleOrRemove = tokens[0];
            string startEndLen = tokens[1];
            var strOrLen = tokens[2];

            List<string> newGuests = new List<string>();

            if (doubleOrRemove == "Remove")
            {
                switch (startEndLen)
                {
                    case "StartsWith":
                        names = names.Where(name => !name.StartsWith(strOrLen)).ToList();
                        break;

                    case "EndsWith":
                        names = names.Where(name => !name.EndsWith(strOrLen)).ToList();
                        break;

                    case "Length":

                        int length = int.Parse(strOrLen);
                        Func<int, bool> checkLength = x => x != length;
                        names = names.Where(name => checkLength(name.Length)).ToList();
                        break;
                }
            }

            else if (doubleOrRemove == "Double")
            {
                switch (startEndLen)
                {
                    case "StartsWith":
                        foreach (var name in names)
                        {
                            if (name.StartsWith(strOrLen))
                            {
                                newGuests.Add(name);
                            }
                        }
                        break;

                    case "EndsWith":
                        foreach (var name in names)
                        {
                            if (name.EndsWith(strOrLen))
                            {
                                newGuests.Add(name);
                            }
                        }
                        break;

                    case "Length":
                        int length = int.Parse(strOrLen);

                        foreach (var name in names)
                        {
                            if (name.Length == length)
                            {
                                newGuests.Add(name);
                            }
                        }
                        break;
                }
            }

            names.AddRange(newGuests);

            return names;
        }
    }
}

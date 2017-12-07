namespace p02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split();
                var action = tokens[0];

                if (action == "A")
                {
                    string name = tokens[1];
                    string phoneNum = tokens[2];

                    phonebook[name] = phoneNum;
                }

                else if (action == "S")
                {
                    string name = tokens[1];


                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }

                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }

                }

                else if (action == "ListAll")
                {
                    foreach (var num in phonebook)
                    {
                        Console.WriteLine($"{num.Key} -> {num.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

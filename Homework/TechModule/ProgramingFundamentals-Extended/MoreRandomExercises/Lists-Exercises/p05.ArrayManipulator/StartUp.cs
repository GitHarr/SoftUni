namespace p05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            

            while (command != "print")
            {
                var tokens = command.Split();
                string tokensName = tokens[0];
                if (tokensName == "add")
                {
                    int index = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);

                    nums.Insert(index, element);
                }

                else if (tokensName == "addMany")
                {
                    int index = int.Parse(tokens[1]);

                    var elements = new List<int>();

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                        elements.Add(currentItem);
                    }

                    // In Linq we can use Skip(num of elements);

                    nums.InsertRange(index, elements);
                }

                else if (tokensName == "contains")
                {
                    int element = int.Parse(tokens[1]);

                    var index = nums.IndexOf(element);

                    Console.WriteLine(index);
                }

                else if (tokensName == "remove")
                {
                    int index = int.Parse(tokens[1]);

                    nums.RemoveAt(index);
                }

                else if (tokensName == "shift")
                {
                    var positions = int.Parse(tokens[1]) % nums.Count;

                    for (int i = 0; i < positions; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }

                else if (tokensName == "sumPairs")
                {
                    var pairsSum = new List<int>();

                    for (int i = 0; i < nums.Count; i += 2)
                    {
                        var currentElement = nums[i];
                        var nextElement = 0;

                        if (i < nums.Count - 1)
                        {
                            nextElement = nums[i + 1];
                        }

                        var elementsSum = currentElement + nextElement;
                         
                        pairsSum.Add(elementsSum);
                    }

                    nums = pairsSum;
                }

                command = Console.ReadLine();
            }
                
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}

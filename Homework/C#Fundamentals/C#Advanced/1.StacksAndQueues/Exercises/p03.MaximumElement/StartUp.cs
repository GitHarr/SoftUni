namespace p03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            int maxNumber = int.MinValue;
            var maxNumbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (line[0] == 1)
                {
                    if (maxNumber < line[1])
                    {
                        maxNumber = line[1];
                        maxNumbers.Push(maxNumber);
                    }

                    stack.Push(line[1]);
                }

                else if (line[0] == 2)
                {
                   if (stack.Pop() == maxNumber)
                    {
                        maxNumbers.Pop();

                        if (maxNumbers.Count != 0)
                        {
                            maxNumber = maxNumbers.Peek();
                        }

                        else
                        {
                            maxNumber = int.MinValue;
                        }
                    }
                }

                else if (line[0] == 3)
                {
                    Console.WriteLine(maxNumber);
                }
            }
        }
    }
}

namespace p02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var elementsToPush = firstLine[0];
            var elementsToPop = firstLine[1];
            var elementToCheck = firstLine[2];

            var secondLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(secondLine[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            
            if (stack.Count > 0)
            {
                if (stack.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(stack.Min());
                } 
            }

            else
            {
                Console.WriteLine(0);   
            }
        }
    }
}

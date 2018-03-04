namespace p04.BasicQueueOperations
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

            var elementsToEnqueue = firstLine[0];
            var elementsToDequeue = firstLine[1];
            var elementToCheck = firstLine[2];

            var secondLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                queue.Enqueue(secondLine[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

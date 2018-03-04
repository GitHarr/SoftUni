namespace p05.SequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            var list = new List<long>(50);

            queue.Enqueue(n);
            list.Add(n);

            long s2 = 0;
            long s3 = 0;
            long s4 = 0;

            for (int i = 0; i < 50; i++)
            {
                s2 = queue.Peek() + 1;
                queue.Enqueue(s2);

                s3 = (2 * queue.Peek()) + 1;
                queue.Enqueue(s3);

                s4 = queue.Peek() + 2;
                queue.Enqueue(s4);

                queue.Dequeue();
                list.Add(s2);
                list.Add(s3);
                list.Add(s4);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}

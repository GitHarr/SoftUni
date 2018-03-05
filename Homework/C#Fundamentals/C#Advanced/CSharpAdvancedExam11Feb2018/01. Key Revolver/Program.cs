using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Key_Revolver
{
    class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int intelValue = int.Parse(Console.ReadLine());

            var bulletStack = new Stack<int>();
            var locksQ = new Queue<int>();

            for (int i = 0; i < bulletsArr.Length; i++)
            {
                bulletStack.Push(bulletsArr[i]);
            }

            for (int i = 0; i < locks.Length; i++)
            {
                locksQ.Enqueue(locks[i]);
            }

            int bulletCount = 0;
            int barrelCount = 0;

            while (bulletStack.Count > 0 && locksQ.Count > 0)
            {
                if (bulletStack.Peek() <= locksQ.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletStack.Pop();
                    locksQ.Dequeue();
                    bulletCount++;
                    barrelCount++;
                }

                else
                {
                    bulletStack.Pop();
                    bulletCount++;
                    barrelCount++;
                    Console.WriteLine("Ping!");
                }

                if (barrelCount == gunBarrel)
                {
                    if (bulletStack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        barrelCount = 0;
                    }
                }
            }

            if (bulletStack.Count > locksQ.Count)
            {
                int earned = intelValue - (bulletCount * bulletPrice);

                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${earned}");
            }

            else if(bulletStack.Count < locksQ.Count)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQ.Count}");
            }

            else if (bulletStack.Count == 0 && locksQ.Count == 0)
            {
                int earned = intelValue - (bulletCount * bulletPrice);

                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${earned}");
            }
        }
    }
}

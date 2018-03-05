using System;

namespace _2._Knights_of_Honor
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

            Action<string> act = str => Console.WriteLine($"Sir {str}");

            for (int i = 0; i < input.Length; i++)
            {
                act.Invoke(input[i]);
            }
        }
    }
}

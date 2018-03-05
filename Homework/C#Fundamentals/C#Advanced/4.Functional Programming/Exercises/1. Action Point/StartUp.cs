using System;

namespace _1._Action_Point
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            Action<string> act = str => Console.WriteLine(str);

            for (int i = 0; i < input.Length; i++)
            {
                act.Invoke(input[i]);
            }
        }
    }
}

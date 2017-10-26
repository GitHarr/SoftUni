namespace p06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<int> rev = getRev(input);
            int sum = rev[0];
            for (int i = 1; i < rev.Count; i++)
            {
                sum += rev[i];
            }
            Console.WriteLine(sum);
        }

        private static List<int> getRev(string input)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string inp = new string(temp);
            string[] a = inp.Split();
            List<int> numbers = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                numbers.Add(int.Parse(a[i]));
            }
            return numbers;
        }
    }
}

namespace p04.Largest3Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

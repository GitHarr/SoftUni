namespace p02.CountSubstringOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            int count = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index == -1)
                {
                    break;
                }

                count++;

            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    public class StartUp
    {
        public static void Main()
        {
            Func<string, bool> checker = s => char.IsUpper(s[0]);   // ---> Checks if string starts with upper case.

            Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}

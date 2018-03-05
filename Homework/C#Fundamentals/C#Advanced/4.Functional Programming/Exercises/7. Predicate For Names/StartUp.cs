using System;

namespace _7._Predicate_For_Names
{
    public class StartUp
    {
        public static void Main()
        {
            int nameLength = int.Parse(Console.ReadLine());

            var strNames = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Predicate<int> isShorter = x => x <= nameLength;
            Action<string> printName = str => Console.WriteLine(str);

            for (int i = 0; i < strNames.Length; i++)
            {
                int currentWordLength = strNames[i].Length;

                if (isShorter.Invoke(currentWordLength))
                {
                    printName.Invoke(strNames[i]);
                }
            }
        }
    }
}

using System.ComponentModel;

namespace p10.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string str = "";
            var lastStrings = new Stack<string>();
            var someString = "";

            lastStrings.Push(str);

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var operands = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var op = int.Parse(operands[0]);

                switch (op)
                {
                    case 1:
                        someString = operands[1];

                        str += someString;

                        lastStrings.Push(str);
                        break;

                    case 2:
                        var count = int.Parse(operands[1]);

                        str = str.Substring(0, str.Length - count);

                        lastStrings.Push(str);
                        break;
                    case 3:

                        var index = int.Parse(operands[1]);

                        Console.WriteLine(str[index - 1]);
                        break;

                    case 4:
                        lastStrings.Pop();

                        str = lastStrings.Peek();
                        break;
                }
            }
        }
    }
}

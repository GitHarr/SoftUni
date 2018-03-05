using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _5._Applied_Arithmetics
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Func<long, long> addFunc = x => x + 1;

            Func<long, long> multiplyFunc = x => x * 2;

            Func<long, long> subtractFunc = x => x - 1;

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] = addFunc.Invoke(inputNums[i]);
                    }
                }

                else if (command == "multiply")
                {
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] = multiplyFunc.Invoke(inputNums[i]);
                    }
                }

                else if (command == "subtract")
                {
                    for (int i = 0; i < inputNums.Length; i++)
                    {
                        inputNums[i] = subtractFunc.Invoke(inputNums[i]);
                    }
                }

                else
                {
                    Console.WriteLine(string.Join(" ", inputNums));
                }
            }
        }
    }
}

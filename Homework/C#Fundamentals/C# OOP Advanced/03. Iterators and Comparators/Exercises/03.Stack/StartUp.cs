using System;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                
                switch (command)
                {
                    case "Push":
                        string[] inputElements = commandArgs.Skip(1).ToArray();
                        stack.Push(inputElements);
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            stack.End();
        }
    }
}

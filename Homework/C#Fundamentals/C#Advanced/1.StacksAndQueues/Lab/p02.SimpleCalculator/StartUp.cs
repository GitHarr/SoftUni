namespace p02.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var reminder = input.Split(' ');

            var stack = new Stack<string>(reminder.Reverse());

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                if (op == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }

                else
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}

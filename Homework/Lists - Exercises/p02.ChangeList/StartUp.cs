namespace p02.ChangeList
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();


            while (command != "Odd" && command != "Even")
            {
                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs[0] == "Delete")
                {
                    int element = int.Parse(commandArgs[1]);
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }

                else if (commandArgs[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                }

                command = Console.ReadLine();
            }

            
            if (command == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                return;
            }

            else if (command == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write($"{numbers[i]} "); 
                    }
                }
                return;
            }
        }
    }
}

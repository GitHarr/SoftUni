namespace p02.ChangeList
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');



            while (true)
            {
                var commandName = command[0];

                if (commandName == "Delete")
                {
                    int element = int.Parse(command[1]);

                    nums.RemoveAll(item => item == element);
                }

                else if (commandName == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    nums.Insert(position, element);
                }

                else if (commandName == "Odd")
                {
                    nums.RemoveAll(items => items % 2 == 0);
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }

                else
                {
                    nums.RemoveAll(items => items % 2 != 0);
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }
}

namespace p02.Icarus
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int subtract = 1;

            while (input != "Supernova")
            {
                string[] commands = input.Split();

                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                switch (direction)
                {
                    case "left":

                        while (steps-- > 0)
                        {
                            if (startIndex == 0)
                            {
                                startIndex = numbers.Length - 1;
                                subtract++;
                                numbers[startIndex] -= subtract;
                                continue;
                            }

                            startIndex--;
                            numbers[startIndex] -= subtract;
                        }

                        break;

                    case "right":

                        while (steps-- > 0)
                        {
                            if (startIndex == numbers.Length - 1)
                            {
                                startIndex = 0;
                                subtract++;
                                numbers[startIndex] -= subtract;
                                continue;
                            }

                            startIndex++;
                            numbers[startIndex] -= subtract;
                        }

                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

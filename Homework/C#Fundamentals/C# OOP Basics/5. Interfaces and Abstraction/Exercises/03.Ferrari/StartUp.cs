using System;

namespace _03.Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();

            ICar ferrari = new global::Ferrari("488-Spider", "Brakes!", "Zadu6avam sA!", driverName);

            Console.WriteLine(ferrari);
        }
    }
}

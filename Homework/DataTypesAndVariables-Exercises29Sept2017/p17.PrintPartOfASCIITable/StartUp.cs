namespace p17.PrintPartOfASCIITable
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= stopNumber; i++)
            {
                Console.Write((char)i + " ");

            }
            Console.WriteLine();
        }
    }
}

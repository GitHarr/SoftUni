namespace p04.VariableInHexFormat
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string str = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(str, 16));
        }
    }
}

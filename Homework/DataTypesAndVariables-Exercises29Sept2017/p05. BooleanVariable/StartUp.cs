namespace p05.BooleanVariable
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (Convert.ToBoolean(input) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

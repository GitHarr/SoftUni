namespace p01.ReverseString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string str = Console.ReadLine();

            Console.WriteLine(str.Reverse().ToArray());

            //string reversed = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversed += str[i];
            //}

            //Console.WriteLine(reversed);
        }
    }
}

namespace p06.StringsAndObjects
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string first = "Hello";
            string second = "World";
            object obj = first + " " + second;
            string objResult = (string)obj;

            Console.WriteLine(objResult);
        }
    }
}

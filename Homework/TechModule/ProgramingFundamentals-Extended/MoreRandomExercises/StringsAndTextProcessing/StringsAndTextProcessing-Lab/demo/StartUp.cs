namespace demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
 
    public class StartUp
    {
       public static void Main()
        {
            string verse = "To be or not to be...";

            int lastIndex = verse.LastIndexOf("be");

            Console.WriteLine(lastIndex);
        }
    }
}

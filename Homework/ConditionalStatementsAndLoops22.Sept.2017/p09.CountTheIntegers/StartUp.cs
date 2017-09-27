
namespace p09.CountTheIntegers
{
    using System;
    public class StartUp
    {
       public static void Main()
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    count += 1;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}

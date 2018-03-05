using System;
using System.IO;

namespace _1._Odd_Lines
{
    public class StartUp
    {
        public static void Main()
        {
            using (var streamReader = new StreamReader(@"..\text.txt"))
            {
                string line;
                int count = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    count++;
                }
            }
        }
    }
}

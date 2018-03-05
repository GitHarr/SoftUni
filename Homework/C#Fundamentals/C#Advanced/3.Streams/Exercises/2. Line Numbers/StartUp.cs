using System;
using System.IO;

namespace _2._Line_Numbers
{
    public class StartUp
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"..\text.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    string line;
                    int count = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"Line {count}: {line}");
                        count++;
                    } 
                }
            }
        }
    }
}

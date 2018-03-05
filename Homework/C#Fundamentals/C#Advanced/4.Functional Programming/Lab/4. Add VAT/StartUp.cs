using System;
using System.Linq;

namespace _4._Add_VAT
{
    public class StartUp
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(d => d * 1.2)
                .ToList()
                .ForEach(d => Console.WriteLine($"{d:f2}"));
        }
    }
}

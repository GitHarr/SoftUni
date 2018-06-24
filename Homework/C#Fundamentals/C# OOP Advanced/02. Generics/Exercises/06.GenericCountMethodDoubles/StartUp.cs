using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<double>> list = new List<Box<double>>();

        Box<double> box = new Box<double>();

        for (int i = 0; i < n; i++)
        {
            box = new Box<double>(double.Parse(Console.ReadLine()));
            list.Add(box);
        }

        double elementToCompare = double.Parse(Console.ReadLine());

        int count = box.CountGreaterElements(list, elementToCompare);

        Console.WriteLine(count);
    }
}


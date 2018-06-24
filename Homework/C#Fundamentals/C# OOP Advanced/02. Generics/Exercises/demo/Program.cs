using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();

        Box<string> box = new Box<string>();

        for (int i = 0; i < n; i++)
        {
            box = new Box<string>(Console.ReadLine());
            list.Add(box);
        }

        string elementToCompare = Console.ReadLine();

        int count = box.CountGreaterElements(list, elementToCompare);

        Console.WriteLine(count);
    }
}


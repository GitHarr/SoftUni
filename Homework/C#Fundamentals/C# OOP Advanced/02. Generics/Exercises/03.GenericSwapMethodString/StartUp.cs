using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();

        Box<string> box = new Box<string>(null);

        for (int i = 0; i < n; i++)
        {
            box = new Box<string>(Console.ReadLine());
            list.Add(box);
        }

        box.Swap(list);

        foreach (var b in list)
        {
            Console.WriteLine(b);
        }
    }
}


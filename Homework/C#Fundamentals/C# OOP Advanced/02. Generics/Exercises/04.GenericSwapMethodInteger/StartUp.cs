using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<int>> list = new List<Box<int>>();

        Box<int> box = new Box<int>();

        for (int i = 0; i < n; i++)
        {
            box = new Box<int>(int.Parse(Console.ReadLine()));
            list.Add(box);
        }

        box.Swap(list);

        foreach (var b in list)
        {
            Console.WriteLine(b);
        }
    }
}


using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();

        Box<string> box = new Box<string>();

        for (int i = 0; i < n; i++)
        {
            string inputStr = Console.ReadLine();
            list.Add(inputStr);
        }

        string elementToCompare = Console.ReadLine();

        int count = box.CountGreaterElements(list, elementToCompare);

        Console.WriteLine(count);
    }
}


using System;

public class StartUp
{
    public static void Main()
    {
        Box<string> box = new Box<string>("life in a box");
        Console.WriteLine(box);
    }
}


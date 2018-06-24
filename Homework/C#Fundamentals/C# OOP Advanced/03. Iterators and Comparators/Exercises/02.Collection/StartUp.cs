using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var createInput = Console.ReadLine().Split();

        var listyIterator = new ListyIterator<string>();
        listyIterator.Create(createInput.Skip(1).ToArray());

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "Print":
                    try
                    {
                        Console.WriteLine(listyIterator);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "PrintAll":
                    try
                    {
                        listyIterator.PrintAll();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public void Run()
    {
        Box<string> box = new Box<string>();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "Add":
                    string element = commandArgs[1];
                    box.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(commandArgs[1]);
                    box.Remove(index);
                    break;
                case "Contains":
                    string elementToCheck = commandArgs[1];
                    Console.WriteLine(box.Contains(elementToCheck));
                    break;
                case "Swap":
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);

                    box.Swap(index1, index2);
                    break;
                case "Greater":
                    string elemToCompare = commandArgs[1];
                    Console.WriteLine(box.CountGreaterThan(elemToCompare));
                    break;
                case "Max":
                    Console.WriteLine(box.Max());
                    break;
                case "Min":
                    Console.WriteLine(box.Min());
                    break;
                case "Print":
                    Console.WriteLine(box);
                    break;
                case "Sort":
                    box.Sort();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
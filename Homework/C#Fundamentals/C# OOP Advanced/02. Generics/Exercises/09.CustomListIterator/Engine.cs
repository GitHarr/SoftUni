using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public void Run()
    {
        CustomList<string> customList = new CustomList<string>();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "Add":
                    string element = commandArgs[1];
                    customList.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(commandArgs[1]);
                    customList.Remove(index);
                    break;
                case "Contains":
                    string elementToCheck = commandArgs[1];
                    Console.WriteLine(customList.Contains(elementToCheck));
                    break;
                case "Swap":
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);

                    customList.Swap(index1, index2);
                    break;
                case "Greater":
                    string elemToCompare = commandArgs[1];
                    Console.WriteLine(customList.CountGreaterThan(elemToCompare));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Print":
                    Console.WriteLine(customList);
                    break;
                case "Sort":
                    customList.Sort();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
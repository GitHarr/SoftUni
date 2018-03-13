using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_FamilyTree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string mainPersonInput = Console.ReadLine();
            FamilyTreeBuilder familyTreeBuilder = new FamilyTreeBuilder(mainPersonInput);

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                ParseInput(input, familyTreeBuilder);
            }

            PrintPersonInfo(familyTreeBuilder.MainPerson); 
        }

        private static void PrintPersonInfo(Person person)
        {
            Console.WriteLine(person);
            Console.WriteLine("Parents:");
            foreach (var p in person.Parents)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Children:");
            foreach (var c in person.Children)
            {
                Console.WriteLine(c);
            }
        }

        private static void ParseInput(string input, FamilyTreeBuilder familyTreeBuilder)
        {
            string[] tokens = input.Split(" - ");
            if (tokens.Length > 1)
            {
                string parrentInput = tokens[0];
                string childInput = tokens[1];
                familyTreeBuilder.SetParentChildRelation(parrentInput, childInput);
            }
            else
            {
                tokens = tokens[0].Split();
                string name = $"{tokens[0]} {tokens[1]}";
                string birthday = tokens[2];

                familyTreeBuilder.SetFullInfo(name, birthday);
            }
        }
    }
}

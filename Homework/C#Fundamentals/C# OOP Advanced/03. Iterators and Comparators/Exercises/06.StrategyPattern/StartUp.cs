using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            SortedSet<Person> sortedName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> sortedAge = new SortedSet<Person>(new AgeComparator());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                sortedName.Add(person);
                sortedAge.Add(person);
            }

            foreach (var p in sortedName)
            {
                Console.WriteLine(p);
            }
            foreach (var p in sortedAge)
            {
                Console.WriteLine(p);
            }
        }
    }
}

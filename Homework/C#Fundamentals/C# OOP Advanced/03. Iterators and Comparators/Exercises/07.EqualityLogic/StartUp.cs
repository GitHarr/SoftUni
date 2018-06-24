using System;
using System.Collections.Generic;

namespace _07.EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedSet = new SortedSet<Person>(new PersonComparator());
            HashSet<Person> hashSet = new HashSet<Person>(new PersonEqualityComparer());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}

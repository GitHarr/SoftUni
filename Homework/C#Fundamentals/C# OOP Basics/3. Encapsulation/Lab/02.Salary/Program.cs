using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Salary
{
    public class Program
    {
        public static void Main()
        {
            var personsCount = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int counter = 0; counter < personsCount; counter++)
            {
                var input = Console.ReadLine().Split();
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                persons.Add(person);
            }

            var percentage = decimal.Parse(Console.ReadLine());

            //persons.ForEach(p => p.IncreaseSalary(percentage));
            //persons.ForEach(p => Console.WriteLine(p));

            persons.ForEach(p =>
            {
                p.IncreaseSalary(percentage);
                Console.WriteLine(p);
            });
        }
    }
}

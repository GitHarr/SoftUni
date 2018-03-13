using System;
using System.Collections.Generic;
using System.Reflection;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();
            var n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var personData = Console.ReadLine().Split();
                var member = new Person(personData[0], int.Parse(personData[1]));
                family.AddMember(member); 
            }


            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}

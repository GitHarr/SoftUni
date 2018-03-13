using System;
using System.Reflection;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        public static void Main()
        {
            MethodInfo membersOverThirtyMethod = typeof(Family).GetMethod("GetMembersOverThirty");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (membersOverThirtyMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var member = new Person(input[0], int.Parse(input[1]));
                family.AddMember(member);
            }

            var membersOverThirty = family.GetMembersOverThirty();

            foreach (var member in membersOverThirty)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}

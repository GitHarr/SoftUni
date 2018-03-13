using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        Team team = new Team("my team");
        var personsCount = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < personsCount; counter++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}


namespace p02.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionsInfo = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionsInfo.ContainsKey(legionName))
                {
                    legionsInfo.Add(legionName, new Dictionary<string, long>());
                    legionActivity.Add(legionName, lastActivity);
                }

                if (!legionsInfo[legionName].ContainsKey(soldierType))
                {
                    legionsInfo[legionName].Add(soldierType, soldierCount);
                }

                else
                {
                    legionsInfo[legionName][soldierType] += soldierCount;
                }

                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }
            }

            string command = Console.ReadLine();

            if (command.IndexOf('\\') != -1)
            {
                long activity = long.Parse(command.Substring(0, command.IndexOf('\\')));
                string soldier = command.Substring(command.IndexOf('\\') + 1);

                foreach (var item in legionsInfo
                    .Where(e => legionsInfo[e.Key].ContainsKey(soldier))
                    .OrderByDescending(k => k.Value[soldier]))
                {
                    if (legionActivity[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[soldier]}");
                    }
                }
            }

            else
            {
                foreach (var item in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionsInfo[item.Key].ContainsKey(command))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}

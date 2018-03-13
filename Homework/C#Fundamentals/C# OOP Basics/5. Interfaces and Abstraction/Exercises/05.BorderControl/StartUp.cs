using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            List<IId> allIDs = new List<IId>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    IId citizen = new Citizen(name, age, id);
                    allIDs.Add(citizen);
                }

                else
                {
                    string model = tokens[0];
                    string id = tokens[1];

                    IId robot = new Robot(model, id);
                    allIDs.Add(robot);
                }
            }

            string idChecker = Console.ReadLine();

            foreach (var id in allIDs.Where(id => id.ID.EndsWith(idChecker)))
            {
                Console.WriteLine(id.ID);
            }
        }
    }
}

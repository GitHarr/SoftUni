using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = Console.ReadLine();

            GetDeparmentsAndDocs(command, doctors, departments);

            command = Console.ReadLine();

            PrintResult(command, departments, doctors);
        }

        private static void PrintResult(string command, Dictionary<string, List<List<string>>> departments, Dictionary<string, List<string>> doctors)
        {
            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }

                command = Console.ReadLine();
            }
        }

        private static void GetDeparmentsAndDocs(string command, Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments)
        {
            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departament = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];
                var fullName = firstName + secondName;

                if (!doctors.ContainsKey(firstName + secondName))
                {
                    doctors[fullName] = new List<string>();
                }

                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool HasFreeBed = departments[departament].SelectMany(x => x).Count() < 60;
                if (HasFreeBed)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                    for (int i = 0; i < departments[departament].Count; i++)
                    {
                        if (departments[departament][i].Count < 3)
                        {
                            room = i;
                            break;
                        }
                    }

                    departments[departament][room].Add(patient);
                }

                command = Console.ReadLine();
            }
        }
    }
}

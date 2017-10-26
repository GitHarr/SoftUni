namespace p10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            List<Town> townsFilled = new List<Town>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                List<string> inputArray = inputLine.Split().ToList();

                if (inputArray.Contains("=>"))
                {
                    List<string> input = Regex.Split(inputLine, @"\s=>\s").ToList();

                    Town workingTown = new Town()
                    {
                        NameOfTown = input[0],
                        SeatsCount = int.Parse(Regex.Match(input[1], @"\d+").Value),
                        Students = new List<Student>()
                    };
                    townsFilled.Add(workingTown);
                }
                else
                {
                    List<string> workingInputArray = inputLine
                        .Trim()
                        .Split(new char[] { '|', ' ' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    Student workingStudents = new Student()
                    {
                        Name = workingInputArray[0] + " " + workingInputArray[1],
                        Email = workingInputArray[2].Trim(),
                        RegistrationDate = DateTime.ParseExact(workingInputArray[3], "d-MMM-yyyy",
                        CultureInfo.InvariantCulture)
                    };
                    townsFilled.LastOrDefault().Students.Add(workingStudents);
                }
                inputLine = Console.ReadLine();
            }

            List<Group> groups = new List<Group>();

            foreach (var town in townsFilled.OrderBy(x => x.NameOfTown))
            {
                IEnumerable<Student> studs = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(z => z.Name)
                    .ThenBy(y => y.Email);

                while (studs.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = studs.Take(group.Town.SeatsCount).ToList();
                    studs = studs.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            int townsCount = groups.Select(x => x.Town).Distinct().Count();

            Console.WriteLine($"Created {groups.Count} groups in {townsCount} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.NameOfTown))
            {
                Console.Write($"{group.Town.NameOfTown} => ");

                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string NameOfTown { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
 

namespace p02.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }

                else
                {
                    grades[name] = new List<double>() { grade };
                }
            }

            foreach (var student in grades)
            {
                var average = 0.0;
                var studentGrades = student.Value;
                var gradesAsString = new List<string>();

                foreach (var grade in studentGrades)
                {
                    average += grade;
                    gradesAsString.Add(string.Format("{0:F2}", grade));
                }

                average /= studentGrades.Count;
                Console.WriteLine($"{student.Key} -> {string.Join(" ", gradesAsString)} (avg: {average:F2})");
            }   

        }
    }
}

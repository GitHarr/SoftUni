using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.IO;
using System.Linq;

namespace P12_IncreaseSalaries
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                string[] departments = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

                var employees = context.Employees
                    .Where(x => departments.Any(s => s == x.Department.Name))
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../Output.txt"))
                {
                    foreach (var e in employees)
                    {
                        e.Salary *= 1.12m;
                        sw.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
                    }
                }

                context.SaveChanges();
            }
        }
    }
}

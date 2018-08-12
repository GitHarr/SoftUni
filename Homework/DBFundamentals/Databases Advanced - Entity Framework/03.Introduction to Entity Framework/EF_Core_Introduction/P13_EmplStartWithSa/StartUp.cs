using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.IO;
using System.Linq;

namespace P13_EmplStartWithSa
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var employees = context.Employees.Where(x => EF.Functions.Like(x.FirstName, "Sa%"))
                    .Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        x.JobTitle,
                        x.Salary
                    })
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToArray();

                using (StreamWriter sw = new StreamWriter("../../Output.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
                    }
                }
            }
        }
    }
}

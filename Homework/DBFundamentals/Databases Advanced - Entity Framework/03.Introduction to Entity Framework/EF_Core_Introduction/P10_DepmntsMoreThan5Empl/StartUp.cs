using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P10_DepmntsMoreThan5Empl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var departmentsEmployees = context.Departments
                    .Where(d => d.Employees.Count > 5)
                    .OrderBy(d => d.Employees.Count)
                    .ThenBy(d => d.Name)
                    .Select(d => new
                    {
                        DepartmentName = d.Name,
                        ManagerName = $"{d.Manager.FirstName} {d.Manager.LastName}",
                        EmplData = d.Employees.Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle
                        }).OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                    }).ToList();

                foreach (var de in departmentsEmployees)
                {
                    Console.WriteLine($"{de.DepartmentName} - {de.ManagerName}");
                    foreach (var e in de.EmplData)
                    {
                        Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                    }

                    Console.WriteLine("----------");
                }
            }
        }
    }
}

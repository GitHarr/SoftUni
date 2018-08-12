using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P09_Employee147
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var employeesProjects = context.Employees
                    .Where(e => e.EmployeeId == 147)
                    .Select(e => new
                    {
                        EmpName = $"{e.FirstName} {e.LastName}",
                        e.JobTitle,
                        Projects = e.EmployeesProjects.Select(p => new
                        {
                            ProjectName = p.Project.Name
                        }).OrderBy(pr => pr.ProjectName)
                    });

                foreach (var ep in employeesProjects)
                {
                    Console.WriteLine($"{ep.EmpName} - {ep.JobTitle}");
                    foreach (var p in ep.Projects)
                    {
                        Console.WriteLine(p.ProjectName);
                    }
                }
            }
        }
    }
}

using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace _5._EmplFromResearchAndDev
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new SoftUniContext())
            {
                var selectedEmployees = dbContext.Employees
                    .Where(e => e.Department.Name == "Research and Development")
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .Select(e => new { e.FirstName, e.LastName, DepartmentName = e.Department.Name, e.Salary });

                foreach (var emp in selectedEmployees)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} from {emp.DepartmentName} - ${emp.Salary:f2}");
                }
            }
        }
    }
}

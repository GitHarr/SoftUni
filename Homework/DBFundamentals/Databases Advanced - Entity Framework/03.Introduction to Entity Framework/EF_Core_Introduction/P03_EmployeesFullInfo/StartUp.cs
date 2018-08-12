using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P03_EmployeesFullInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                context.Employees
                       .OrderBy(e => e.EmployeeId)
                       .Select(e => new
                       {
                           e.FirstName,
                           e.LastName,
                           e.MiddleName,
                           e.JobTitle,
                           e.Salary
                       })
                       .ToList()
                       .ForEach(e =>
                       Console.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}"));
            }
        }
    }
}

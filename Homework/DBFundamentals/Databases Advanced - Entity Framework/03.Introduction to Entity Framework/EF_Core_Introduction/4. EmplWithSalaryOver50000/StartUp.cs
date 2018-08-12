namespace P04_EmplWithSalaryOver50000
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();

            using (dbContext)
            {
                var employeesNames = dbContext.Employees
                    .Where(e => e.Salary > 50000)
                    .OrderBy(e => e.FirstName)
                    .Select(e => e.FirstName);

                foreach (var empName in employeesNames)
                {
                    Console.WriteLine(empName);
                }
            }
        }
    }
}

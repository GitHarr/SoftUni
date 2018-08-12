using P02_DatabaseFirst.Data;
using System;
using System.Globalization;
using System.Linq;

namespace P11.FindLatest10Projects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var projects = context.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .Select(p => new
                    {
                        p.Name,
                        p.Description,
                        p.StartDate
                    }).OrderBy(p => p.Name);

                foreach (var p in projects)
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Description);
                    Console.WriteLine(p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}

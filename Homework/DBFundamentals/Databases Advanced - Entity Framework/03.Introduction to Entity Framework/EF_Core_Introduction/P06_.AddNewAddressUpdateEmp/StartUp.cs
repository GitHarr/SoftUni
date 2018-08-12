using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P06_.AddNewAddressUpdateEmp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var address = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };

                Employee employee = context.Employees
                    .SingleOrDefault(e => e.LastName == "Nakov");

                employee.Address = address;

                context.SaveChanges();

                var employees = context.Employees
                    .OrderByDescending(e => e.AddressId)
                    .Take(10)
                    .Select(e => new { e.Address.AddressText })
                    .ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.AddressText}");
                }
            }
        }
    }
}

using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P08.AddressesByTown
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var addresses = context.Addresses
                    .GroupBy(a => new
                    {
                        a.AddressId,
                        a.AddressText,
                        a.Town.Name
                    },
                        (key, group) => new {
                            AddressText = key.AddressText,
                            Town = key.Name,
                            Count = group.Sum(a => a.Employees.Count)
                        })
                    .OrderByDescending(a => a.Count)
                    .ThenBy(t => t.Town)
                    .ThenBy(a => a.AddressText)
                    .Take(10);

                foreach (var a in addresses)
                {
                    Console.WriteLine($"{a.AddressText}, {a.Town} - {a.Count} employees");
                }
            }
        }
    }
}

using Employee.App.Core.Contracts;
using Employee.App.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.App.Core.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly IEmployeeController employeeController;

        public AddEmployeeCommand(IEmployeeController controller)
        {
            this.employeeController = controller;
        }

        public string Execute(string[] args)
        {
            string firstName = args[0];
            string lastName = args[1];
            decimal salary = decimal.Parse(args[2]);

            EmployeeDto employeeDto = new EmployeeDto
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            };

            this.employeeController.AddEmployee(employeeDto);

            return $"Employee {firstName} {lastName} was added successfully";
        }
    }
}

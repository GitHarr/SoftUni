namespace Employee.App.Core.Commands
{
    using Employee.App.Core.Contracts;
    using System;

    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeController employeeController;

        public EmployeePersonalInfoCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);

            var employeeDto = this.employeeController.GetEmployeePersonalInfo(id);

            return $"ID: {employeeDto.Id} - {employeeDto.FirstName} {employeeDto.LastName} " +
                   $"- ${employeeDto.Salary:f2}/n" +
                   $"Birthday: {employeeDto.Birthday.Value.ToString("dd-MM-yyyy")}/n" +
                   $"Address: {employeeDto.Address}/n";
        }
    }
}

namespace Employee.App.Core.Commands
{
    using Employee.App.Core.Contracts;
    using System;
    using System.Text;

    public class ManagerInfoCommand : ICommand
    {
        private readonly IManagerController managerController;

        public ManagerInfoCommand()
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int employeeId = int.Parse(args[0]);

            var managerDto = this.managerController.GetManagerInfo(employeeId);

            sb.AppendLine($"{managerDto.FirstName} {managerDto.LastName} | Employees: " +
                $"{managerDto.EmployeesCount}");

            foreach (var empl in managerDto.EmployeesDto)
            {
                sb.AppendLine($"    - {empl.FirstName} {empl.LastName} - {empl.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}

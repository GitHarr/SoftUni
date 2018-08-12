namespace Employee.App.Core.Commands
{
    using Employee.App.Core.Contracts;
    using System;

    public class SetManagerCommand : ICommand
    {
        private readonly IManagerController managerController;

        public SetManagerCommand(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            int managerId = int.Parse(args[1]);

            this.managerController.SetManager(employeeId, managerId);

            return "Command completed successfully";
        }
    }
}

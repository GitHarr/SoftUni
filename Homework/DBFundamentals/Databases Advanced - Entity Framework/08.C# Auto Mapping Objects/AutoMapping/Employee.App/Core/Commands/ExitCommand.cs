namespace Employee.App.Core.Commands
{
    using Employee.App.Core.Contracts;
    using System;
    using System.Threading;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                System.Console.WriteLine($"Program will close after {i} seconds");
                Thread.Sleep(1000);
            }

            Environment.Exit(0);

            return null;
        }
    }
}

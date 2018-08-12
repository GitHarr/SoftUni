namespace Employee.App.Core
{
    using System;

    using Employee.App.Core.Contracts;
    using Employee.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;

    public class Engine : IEngine
    {
        private IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            var initializeDb = this.serviceProvider.GetService<IDbInitializerService>();
            initializeDb.InitializeDatabase();

            var commandInterpreter = this.serviceProvider.GetService<ICommandInterpreter>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}

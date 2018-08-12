namespace Employee.App
{
    using System;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using Data;
    using Services;
    using Services.Contracts;
    using Employee.App.Core.Contracts;
    using Employee.App.Core;
    using AutoMapper;
    using Employee.App.Core.Controllers;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var service = ConfigureService();

            IEngine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeeContext>
                (opts => opts.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddAutoMapper(conf => conf.AddProfile<EmployeeProfile>());

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();

            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();

            serviceCollection.AddTransient<IManagerController, ManagerController>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}

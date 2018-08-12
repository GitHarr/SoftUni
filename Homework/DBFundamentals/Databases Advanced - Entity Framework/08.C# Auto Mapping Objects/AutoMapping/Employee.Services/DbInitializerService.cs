namespace Employee.Services
{
    using System;

    using Employee.Data;
    using Employee.Services.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class DbInitializerService : IDbInitializerService
    {
        private readonly EmployeeContext context;

        public DbInitializerService(EmployeeContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.EnsureDeleted();
            this.context.Database.Migrate();
        }
    }
}

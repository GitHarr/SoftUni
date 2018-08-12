using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Services.Contracts
{
    public interface IDbInitializerService
    {
        void InitializeDatabase();
    }
}

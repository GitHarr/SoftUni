using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Data
{
    public class Configuration
    {
        public static string ConnectionString =>
            @"Server=COMPHARR\SQLEXPRESS02;Database=Employees;Integrated Security=True";
    }
}

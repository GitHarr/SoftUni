using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Data
{
    public class Configuration
    {
        public static string ConnectionString =>
            @"Server=COMPHARR\SQLEXPRESS02;Database=CarDealer;Integrated Security=True";
    }
}

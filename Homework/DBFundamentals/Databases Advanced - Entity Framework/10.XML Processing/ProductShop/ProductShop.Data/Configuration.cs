using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Data
{
    public class Configuration
    {
        public static string ConnectionString =>
            @"Server=COMPHARR\SQLEXPRESS02;Database=ProductShop;Integrated Security=True";
    }
}

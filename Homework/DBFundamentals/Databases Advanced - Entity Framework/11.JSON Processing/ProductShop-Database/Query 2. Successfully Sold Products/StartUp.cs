using Newtonsoft.Json;
using ProductShop.Data;
using System;
using System.IO;
using System.Linq;

namespace Query_2._Successfully_Sold_Products
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            var users = context.Users
                               .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
                               .OrderBy(l => l.LastName)
                               .ThenBy(x => x.FirstName)
                               .Select(s => new
                               {
                                   firstName = s.FirstName,
                                   lastName = s.LastName,
                                   soldProducts = s.ProductsSold.Where(x => x.Buyer != null)
                                                                .Select(v => new
                                                                {
                                                                    name = v.Name,
                                                                    price = v.Price,
                                                                    buyerFirstName = v.Buyer.FirstName,
                                                                    buyerLastName = v.Buyer.LastName
                                                                })
                                                                .ToArray()
                               })
                               .ToArray();

            var jsonUsers = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../users-sold-products.json", jsonUsers);
        }
    }
}

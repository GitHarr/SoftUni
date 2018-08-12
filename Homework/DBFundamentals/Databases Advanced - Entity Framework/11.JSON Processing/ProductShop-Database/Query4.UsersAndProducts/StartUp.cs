using Newtonsoft.Json;
using ProductShop.Data;
using System;
using System.IO;
using System.Linq;

namespace Query4.UsersAndProducts
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            var users = new
            {
                usersCount = context.Users.Count(),
                users = context.Users
                               .OrderByDescending(x => x.ProductsSold.Count)
                               .ThenBy(l => l.LastName)
                               .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
                               .Select(x => new
                               {
                                   firstName = x.FirstName,
                                   lastName = x.LastName,
                                   age = x.Age,
                                   soldProducts = new
                                   {
                                       count = x.ProductsSold.Count,
                                       products = x.ProductsSold.Select(s => new
                                       {
                                           name = s.Name,
                                           price = s.Price
                                       })
                                       .ToArray()
                                   }
                               })
                               .ToArray()
            };

            var jsonUsers = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../users-and-products.json", jsonUsers);
        }
    }
}

using Newtonsoft.Json;
using ProductShop.Data;
using System;
using System.IO;
using System.Linq;

namespace Query_1._Products_In_Range
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            var products = context.Products
                                  .Where(x => x.Price >= 500 && x.Price <= 1000)
                                  .OrderBy(x => x.Price)
                                  .Select(s => new
                                  {
                                      name = s.Name,
                                      price = s.Price,
                                      seller = s.Seller.FirstName + " " + s.Seller.LastName ?? s.Seller.LastName
                                  })
                                  .ToArray();

            var jsonProducts = JsonConvert.SerializeObject(products, Formatting.Indented);

            File.WriteAllText("../../../products-in-range.json", jsonProducts);
        }
    }
}

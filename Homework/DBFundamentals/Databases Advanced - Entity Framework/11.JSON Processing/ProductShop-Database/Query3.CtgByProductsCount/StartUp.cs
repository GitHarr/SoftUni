using Newtonsoft.Json;
using ProductShop.Data;
using System;
using System.IO;
using System.Linq;

namespace Query3.CtgByProductsCount
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            var categories = context.Categories
                                    .Select(x => new
                                    {
                                        category = x.Name,
                                        productCount = x.CategoryProducts.Count(),
                                        averagePrice = x.CategoryProducts
                                                        .Sum(s => s.Product.Price) / x.CategoryProducts.Count(),
                                        totalRevenue = x.CategoryProducts.Sum(s => s.Product.Price)
                                    })
                                    .OrderByDescending(x => x.productCount)
                                    .ToArray();

            var jsonCategories = JsonConvert.SerializeObject(categories, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            });

            File.WriteAllText("../../../categories-by-products.json", jsonCategories);
        }
    }
}

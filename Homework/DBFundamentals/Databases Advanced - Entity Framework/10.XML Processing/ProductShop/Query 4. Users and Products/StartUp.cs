using ProductShop.App.Dto.Export;
using ProductShop.Data;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Query_4._Users_and_Products
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            var users = new UsersDtoEx
            {
                Count = context.Users.Count(),
                Users = context.Users
                               .Where(x => x.ProductsSold.Count >= 1)
                               .Select(x => new UserDtoExEx
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age.ToString(),
                    SoldProducts = new SoldProductEx
                    {
                        Count = x.ProductsSold.Count(),
                        ProductDto = x.ProductsSold.Select(k => new ProductDtoExEx
                        {
                            Name = k.Name,
                            Price = k.Price
                        }).ToArray()
                    }
                }).ToArray()
            };

            var sb = new StringBuilder();

            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            var serializer = new XmlSerializer(typeof(UsersDtoEx), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, xmlNamespaces);

            File.WriteAllText("../../../users-and-products.xml", sb.ToString());
        }
    }
}

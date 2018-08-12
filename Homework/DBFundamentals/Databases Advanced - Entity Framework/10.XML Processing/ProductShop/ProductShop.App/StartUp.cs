namespace ProductShop.App
{
    using AutoMapper;
    using App.Dto;
    using Models;
    using System;
    using System.IO;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using ProductShop.Data;
    using System.Linq;
    using ProductShop.App.Dto.Export;
    using System.Text;
    using System.Xml;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var context = new ProductShopContext();

            //Query 4. Users and Products

            //Query 3. Categories By Products Count
            //var categories = context.Categories
            //                        .OrderByDescending(x => x.CategoryProducts.Count)
            //                        .Select(x => new CategoryDtoEx
            //                        {
            //                            Name = x.Name,
            //                            Count = x.CategoryProducts.Count,
            //                            TotalRevenue = x.CategoryProducts.Sum(s => s.Product.Price),
            //                            AveragePrice = x.CategoryProducts.Select(s => s.Product.Price)
            //                                                             .DefaultIfEmpty(0).Average()
            //                        })
            //                        .ToArray();


            //Query 2. Sold Products
            //var users = context.Users
            //                   .Where(x => x.ProductsSold.Count >= 1)
            //                   .Select(x => new UserDtoEx
            //                   {
            //                       FirstName = x.FirstName,
            //                       LastName = x.LastName,
            //                       SoldProducts = x.ProductsSold.Select(s => new SoldProduct
            //                       {
            //                           Name = s.Name,
            //                           Price = s.Price
            //                       })
            //                       .ToArray()
            //                   })
            //                   .OrderBy(x => x.LastName)
            //                   .ThenBy(x => x.FirstName)
            //                   .ToArray();

            //Query 1. Products In Range
            //var products = context.Products
            //                      .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
            //                      .OrderByDescending(p => p.Price)
            //                      .Select(x => new ProductDtoEx
            //                      {
            //                          Name = x.Name,
            //                          Price = x.Price,
            //                          Buyer = x.Buyer.FirstName + " " + x.Buyer.LastName
            //                      })
            //                      .ToArray();

            //var sb = new StringBuilder();

            //var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            //var serializer = new XmlSerializer(typeof(CategoryDtoEx[]), new XmlRootAttribute("categories"));
            //serializer.Serialize(new StringWriter(sb), categories, xmlNamespaces);

            //File.WriteAllText("../../../Xml/categories-by-products.xml", sb.ToString());

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<ProductShopProfile>();
            //});

            //var mapper = config.CreateMapper();

            //Add CategoryProducts
            //var categoryProducts = new List<CategoryProduct>();

            //for (int productId = 1; productId <= 99; productId++)
            //{
            //    var categoryId = new Random().Next(1, 11);

            //    var categoryProduct = new CategoryProduct()
            //    {
            //        ProductId = productId,
            //        CategoryId = categoryId
            //    };

            //    categoryProducts.Add(categoryProduct);
            //}

            //var context = new ProductShopContext();
            //context.CategoryProducts.AddRange(categoryProducts);
            //context.SaveChanges();

            //Add Categories
            //var xmlString = File.ReadAllText("../../../Xml/categories.xml");

            //var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("categories"));
            //var deserializedCategories = (CategoryDto[])serializer.Deserialize(new StringReader(xmlString));

            //var categories = new List<Category>();

            //foreach (var categoryDto in deserializedCategories)
            //{
            //    if (!IsValid(categoryDto))
            //    {
            //        continue;
            //    }

            //    var category = mapper.Map<Category>(categoryDto);

            //    categories.Add(category);
            //}

            //var context = new ProductShopContext();
            //context.Categories.AddRange(categories);
            //context.SaveChanges();


            //Add Products 
            //var xmlString = File.ReadAllText("../../../Xml/products.xml");

            //var serializer = new XmlSerializer(typeof(ProductDto[]), new XmlRootAttribute("products"));

            //var deserializedUsers = (ProductDto[])serializer.Deserialize(new StringReader(xmlString));

            //List<Product> products = new List<Product>();

            //int counter = 1;

            //foreach (var productDto in deserializedUsers)
            //{
            //    if (!IsValid(productDto))
            //    {
            //        continue;
            //    }

            //    var product = mapper.Map<Product>(productDto);

            //    var buyerId = new Random().Next(1, 30);
            //    var sellerId = new Random().Next(31, 56);

            //    product.BuyerId = buyerId;
            //    product.SellerId = sellerId;

            //    if (counter == 4)
            //    {
            //        product.BuyerId = null;
            //        counter = 0;
            //    }

            //    products.Add(product);

            //    counter++;
            //}

            //var context = new ProductShopContext();
            //context.Products.AddRange(products);
            //context.SaveChanges();
        }

        //public static bool IsValid(object obj)
        //{
        //    var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
        //    var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

        //    return System.ComponentModel.DataAnnotations.Validator
        //                 .TryValidateObject(obj, validationContext, validationResults, true);
        //}
    }
}

namespace ProductShop.App
{
    using AutoMapper;

    using Data;
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //    var config = new MapperConfiguration(cfg =>
            //    {
            //        cfg.AddProfile<ProductShopProfile>();
            //    });
            //    var mapper = config.CreateMapper();

            //var context = new ProductShopContext();

            //Add Categoties
            //var categoryProducts = new List<CategoryProduct>();

            //for (int productId = 201; productId <= 400; productId++)
            //{
            //    var categoryId = new Random().Next(1, 12);

            //    var categoryProduct = new CategoryProduct
            //    {
            //        CategoryId = categoryId,
            //        ProductId = productId
            //    };

            //    categoryProducts.Add(categoryProduct);
            //}

            //context.CategoryProducts.AddRange(categoryProducts);
            //context.SaveChanges();


            //Add Categories
            //var jsonString = File.ReadAllText("../../../Json/categories.json");

            //var deserializedCategories = JsonConvert.DeserializeObject<Category[]>(jsonString);

            //List<Category> categiries = new List<Category>();

            //foreach (var category in deserializedCategories)
            //{
            //    if (!IsValid(category))
            //    {
            //        continue;
            //    }

            //    categiries.Add(category);
            //}

            //context.Categories.AddRange(categiries);
            //context.SaveChanges();

            //Add Products
            //var jsonString = File.ReadAllText("../../../Json/products.json");

            //var deserializedProducts = JsonConvert.DeserializeObject<Product[]>(jsonString);

            //List<Product> products = new List<Product>();

            //foreach (var product in deserializedProducts)
            //{
            //    if (!IsValid(product))
            //    {
            //        continue;
            //    }

            //    var sellerId = new Random().Next(1, 35);
            //    var buyerId = new Random().Next(35, 57);

            //    var randon = new Random().Next(1, 4);

            //    product.SellerId = sellerId;
            //    product.BuyerId = buyerId;

            //    if (randon == 3)
            //    {
            //        product.BuyerId = null;
            //    }

            //    products.Add(product);
            //}

            //context.Products.AddRange(products);
            //context.SaveChanges();


            //Add Users
            //var jsonString = File.ReadAllText("../../../Json/users.json");

            //var deserializedUsers = JsonConvert.DeserializeObject<User[]>(jsonString);

            //List<User> users = new List<User>();

            //foreach (var user in deserializedUsers)
            //{
            //    if (IsValid(user))
            //    {
            //        users.Add(user); 
            //    }
            //}

            //context.Users.AddRange(users);
            //context.SaveChanges();
        }

        //public static bool IsValid(object obj)
        //{
        //    var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
        //    var result = new List<ValidationResult>();

        //    return Validator.TryValidateObject(obj, validationContext, result, true);
        //}
    }
}

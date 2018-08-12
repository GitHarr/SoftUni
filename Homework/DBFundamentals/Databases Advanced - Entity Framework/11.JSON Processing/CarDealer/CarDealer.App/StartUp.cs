using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CarDealer.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new CarDealerContext();

            

            //Add Parts
            //var jsonString = File.ReadAllText("../../../Json/parts.json");

            //var deserializedParts = JsonConvert.DeserializeObject<Part[]>(jsonString);

            //List<Part> parts = new List<Part>();

            //foreach (var part in deserializedParts)
            //{
            //    if (!IsValid(part))
            //    {
            //        continue;
            //    }

            //    int suplierId = new Random().Next(1, 32);

            //    part.Supplier = (Supplier)context.Suppliers.Where(x => x.Id == suplierId).SingleOrDefault();

            //    parts.Add(part);
            //}

            //context.Parts.AddRange(parts);
            //context.SaveChanges();


            //Add Suppliers
            //var jsonString = File.ReadAllText("../../../Json/suppliers.json");

            //var deserializedSuppliers = JsonConvert.DeserializeObject<Supplier[]>(jsonString);

            //List<Supplier> suppliers = new List<Supplier>();

            //foreach (var supplier in deserializedSuppliers)
            //{
            //    if (IsValid(supplier))
            //    {
            //        suppliers.Add(supplier);
            //    }
            //}

            //context.Suppliers.AddRange(suppliers);
            //context.SaveChanges();
        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

            return System.ComponentModel.DataAnnotations.Validator
                         .TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}

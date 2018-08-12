using AutoMapper;
using CarDealer.App.Dtos.ImportDtos;
using CarDealer.Data;
using CarDealer.Models;
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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            var mapper = config.CreateMapper();

            var xmlString = File.ReadAllText("../../../XML/Import/parts.xml");

            var serializer = new XmlSerializer
                                (typeof(PartDto[]), new XmlRootAttribute("parts"));

            var deserializedParts = (PartDto[])serializer.Deserialize
                                                                   (new StringReader(xmlString));
            List<Part> parts = new List<Part>();

            var context = new CarDealerContext();

            foreach (var partDto in deserializedParts)
            {
                if (!IsValid(partDto))
                {
                    continue;
                }

                var part = mapper.Map<Part>(partDto);

                var supplierId = new Random().Next(1, 32);

                var supplier = (Supplier)context.Suppliers
                                                .Where(x => x.Id == supplierId)
                                                .SingleOrDefault();

                part.Supplier = supplier;

                parts.Add(part);
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();


            //Add Suppliers
            //    var suppliers = new List<Supplier>();

            //    foreach (var supplierDto in deserializedSuppliers)
            //    {
            //        if (!IsValid(supplierDto))
            //        {
            //            continue;
            //        }

            //        var supplier = mapper.Map<Supplier>(supplierDto);

            //        suppliers.Add(supplier);
            //    }

            //    var context = new CarDealerContext();
            //    context.Suppliers.AddRange(suppliers);
            //    context.SaveChanges();
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

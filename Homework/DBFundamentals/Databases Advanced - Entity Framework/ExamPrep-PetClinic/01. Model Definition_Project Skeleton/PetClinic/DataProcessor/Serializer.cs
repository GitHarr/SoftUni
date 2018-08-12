namespace PetClinic.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using PetClinic.Data;
    using PetClinic.Dto.ExportDto;

    public class Serializer
    {
        public static string ExportAnimalsByOwnerPhoneNumber(PetClinicContext context, string phoneNumber)
        {
            var animal = context.Animals
                                .Where(x => x.Passport.OwnerPhoneNumber == phoneNumber)
                                .Select(ai => new AnimalDto
                                {
                                    OwnerName = ai.Passport.OwnerName,
                                    AnimalName = ai.Name,
                                    Age = ai.Age,
                                    SerialNumber = ai.PassportSerialNumber,
                                    RegisteredOn = ai.Passport.RegistrationDate
                                                     .ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
                                })
                                .OrderBy(x => x.Age)
                                .ThenBy(s => s.SerialNumber)
                                .ToArray();

            var json = JsonConvert.SerializeObject(animal, Newtonsoft.Json.Formatting.Indented);

            return json;
        }

        public static string ExportAllProcedures(PetClinicContext context)
        {
            var procedure = context.Procedures.OrderBy(x => x.DateTime)
                .Select(p => new ProcedureDto
                {
                    Passport = p.Animal.PassportSerialNumber,
                    OwnerNumber = p.Animal.Passport.OwnerPhoneNumber,
                    DateTime = p.DateTime.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                    AnimalAids = p.ProcedureAnimalAids.Select(pa => new AnimalAidDto
                    {
                        Name = pa.AnimalAid.Name,
                        Price = pa.AnimalAid.Price
                    }).ToArray(),
                    TotalPrice = p.ProcedureAnimalAids.Sum(ai => ai.AnimalAid.Price)
                })
                .OrderBy(p => p.Passport)
                .ToArray();

            var sb = new StringBuilder();
            var serializer = new XmlSerializer(typeof(ProcedureDto[]),
                new XmlRootAttribute("Procedures"));

            serializer.Serialize(new StringWriter(sb), procedure,
                new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString().TrimEnd();
            return result;
        }
    }
}

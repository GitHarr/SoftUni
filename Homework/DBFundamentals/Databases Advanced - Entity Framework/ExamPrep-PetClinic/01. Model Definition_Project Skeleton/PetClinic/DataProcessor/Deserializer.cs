namespace PetClinic.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using Newtonsoft.Json;
    using PetClinic.Data;
    using PetClinic.Dto.ImportDto;
    using PetClinic.Models;

    public class Deserializer
    {
        private static string ERROR_MESSAGE = "Error: Invalid data.";

        public static string ImportAnimalAids(PetClinicContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var deserializedJson = JsonConvert.DeserializeObject<AnimalAidDto[]>(jsonString);
            var validAnimalAids = new List<AnimalAid>();

            foreach (var animalAidDto in deserializedJson)
            {
                var animalAidExists = validAnimalAids.Any(x => x.Name == animalAidDto.Name);

                if (!IsValid(animalAidDto) || animalAidExists)
                {
                    sb.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var animalAid = Mapper.Map<AnimalAid>(animalAidDto);

                validAnimalAids.Add(animalAid);
                sb.AppendLine($"Record {animalAid.Name} successfully imported.");
            }

            context.AnimalAids.AddRange(validAnimalAids);
            context.SaveChanges();

            string restult = sb.ToString().TrimEnd();
            return restult;
        }

        public static string ImportAnimals(PetClinicContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var deserializedJson = JsonConvert.DeserializeObject<AnimalDto[]>(jsonString);
            var validAnimals = new List<Animal>();

            foreach (var animalDto in deserializedJson)
            {
                var passportSerialNumberExists = validAnimals.Any
                    (x => x.Passport.SerialNumber == animalDto.Passport.SerialNumber);

                if (!IsValid(animalDto) || !IsValid(animalDto.Passport) || passportSerialNumberExists)
                {
                    sb.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var validAnimal = Mapper.Map<Animal>(animalDto);

                validAnimals.Add(validAnimal);

                sb.AppendLine($"Record {animalDto.Name} " +
                    $"Passport №: {animalDto.Passport.SerialNumber} successfully imported.");
            }

            context.Animals.AddRange(validAnimals);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportVets(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(VetDto[]), new XmlRootAttribute("Vets"));
            var deserializedXml = (VetDto[])serializer.Deserialize(new StringReader(xmlString));

            var validVets = new List<Vet>();
            var sb = new StringBuilder();

            foreach (var vetDto in deserializedXml)
            {
                var vetExists = validVets.Any(x => x.PhoneNumber == vetDto.PhoneNumber);

                if (!IsValid(vetDto) || vetExists)
                {
                    sb.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var validVet = Mapper.Map<Vet>(vetDto);
                validVets.Add(validVet);
                sb.AppendLine($"Record {vetDto.Name} successfully imported.");
            }

            context.Vets.AddRange(validVets);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportProcedures(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ProcedureDto[]), new XmlRootAttribute("Procedures"));
            var deserializedXml = (ProcedureDto[])serializer.Deserialize(new StringReader(xmlString));

            var validProcedures = new List<Procedure>();
            var sb = new StringBuilder();

            foreach (var procedureDto in deserializedXml)
            {
                var vetObj = context.Vets.SingleOrDefault(x => x.Name == procedureDto.Vet);
                var animalObj = context.Animals
                                .SingleOrDefault(x => x.PassportSerialNumber == procedureDto.Animal);

                var validProcedureAnimalAids = new List<ProcedureAnimalAid>();
                bool allAidsExist = true;

                foreach (var procedureDtoAnimalAid in procedureDto.AnimalAids)
                {
                    var animalAid = context.AnimalAids
                                    .SingleOrDefault(ai => ai.Name == procedureDtoAnimalAid.Name);

                    if (animalAid == null 
                        || validProcedureAnimalAids
                                    .Any(p => p.AnimalAid.Name == procedureDtoAnimalAid.Name))
                    {
                        allAidsExist = false;
                        break;
                    }

                    var animalAidProcedure = new ProcedureAnimalAid
                    {
                        AnimalAid = animalAid
                    };

                    validProcedureAnimalAids.Add(animalAidProcedure);
                }

                if (!IsValid(procedureDto) 
                    || vetObj == null
                    || !procedureDto.AnimalAids.All(IsValid)
                    || animalObj == null
                    || !allAidsExist)
                {
                    sb.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var proc = new Procedure
                {
                    Animal = animalObj,
                    Vet = vetObj,
                    DateTime = DateTime.ParseExact(procedureDto.DateTime, "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ProcedureAnimalAids = validProcedureAnimalAids
                };

                validProcedures.Add(proc);
                sb.AppendLine("Record successfully imported.");
            }

            context.Procedures.AddRange(validProcedures);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();
            return result;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResult, true);
        }
    }
}

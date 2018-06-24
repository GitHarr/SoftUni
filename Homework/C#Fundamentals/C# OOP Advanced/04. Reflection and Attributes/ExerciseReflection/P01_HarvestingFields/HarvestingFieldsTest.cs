 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string command;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                Type type = typeof(HarvestingFields);
                FieldInfo[] fieldsToPrint = 
                    type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                switch (command)
                {
                    case "private":
                        foreach (FieldInfo f in fieldsToPrint.Where(f => f.IsPrivate))
                        {
                            Console.WriteLine($"private {f.FieldType.Name} {f.Name}");
                        }
                        break;
                    case "protected":
                        foreach (FieldInfo f in fieldsToPrint.Where(f => f.IsFamily))
                        {
                            Console.WriteLine($"protected {f.FieldType.Name} {f.Name}");
                        }
                        break;
                    case "public":
                        foreach (FieldInfo f in fieldsToPrint.Where(f => f.IsPublic))
                        {
                            Console.WriteLine($"public {f.FieldType.Name} {f.Name}");
                        }
                        break;
                    case "all":
                        foreach (FieldInfo f in fieldsToPrint)
                        {
                            if (f.Attributes.ToString().ToLower() == "family")
                            {
                                Console.WriteLine($"protected {f.FieldType.Name} {f.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}");
                            }
                        }
                        break;
                }
            }
        }
    }
}

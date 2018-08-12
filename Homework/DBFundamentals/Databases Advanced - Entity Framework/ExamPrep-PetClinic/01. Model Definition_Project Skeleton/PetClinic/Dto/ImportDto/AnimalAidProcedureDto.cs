using System.Xml.Serialization;

namespace PetClinic.Dto.ImportDto
{
    [XmlType("AnimalAid")]
    public class AnimalAidProcedureDto
    {
        public string Name { get; set; }
    }
}
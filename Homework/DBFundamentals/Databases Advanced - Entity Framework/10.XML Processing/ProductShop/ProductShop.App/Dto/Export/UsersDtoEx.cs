using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.App.Dto.Export
{
    [XmlRoot("users")]
    public class UsersDtoEx
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("user")]
        public UserDtoExEx[] Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.App.Dto.Export
{
    [XmlType("sold-product")]
    public class SoldProductEx
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("product")]
        public ProductDtoExEx[] ProductDto { get; set; }
    }
}

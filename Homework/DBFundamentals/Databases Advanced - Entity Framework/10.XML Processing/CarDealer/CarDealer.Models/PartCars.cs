using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Models
{
    public class PartCars
    {
        [Required]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}

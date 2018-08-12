using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Models
{
    public class Part
    {
        public Part()
        {
            this.PartCars = new List<PartCars>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public ICollection<PartCars> PartCars { get; set; }
        
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}

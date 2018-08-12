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
            this.Cars = new List<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Models
{
    public class Car
    {
        public Car()
        {
            this.CarParts = new List<PartCars>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public long TravelledDistance { get; set; }

        public ICollection<PartCars> CarParts { get; set; }
    }
}

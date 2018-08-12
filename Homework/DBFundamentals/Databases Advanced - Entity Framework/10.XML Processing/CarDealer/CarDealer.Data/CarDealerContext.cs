using CarDealer.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarDealer.Data
{
    public class CarDealerContext : DbContext
    {
        public CarDealerContext() { }

        public CarDealerContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartCars> PartCars { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartCars>().HasKey(x => new { x.PartId, x.CarId });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasMany(x => x.Parts);
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasMany(x => x.Cars);

                entity.HasOne(x => x.Supplier);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasMany(x => x.Parts);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasOne(x => x.Customer);

                entity.HasOne(x => x.Car);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasMany(x => x.CarsBought);
            });
        }
    }
}

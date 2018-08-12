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

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasOne(x => x.Supplier)
                      .WithMany(x => x.Parts)
                      .HasForeignKey(x => x.SupplierId);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasOne(x => x.Customer)
                      .WithMany(x =>x.CarsBought)
                      .HasForeignKey(x => x.CustomerId);
            });
        }
    }
}

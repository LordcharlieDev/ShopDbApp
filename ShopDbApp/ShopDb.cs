using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public class ShopDb : DbContext
    {
        public ShopDb() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SEGB2UP;Initial catalog = ShopDb;Integrated Security=True;Connect Timeout=5;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedCategories();
            modelBuilder.SeedCountries();
            modelBuilder.SeedPosition();


            //Configurations
            modelBuilder.Entity<Category>().Property(c => c.Name)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<City>().Property(c => c.Name)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Country>().Property(c => c.Name)
                                .HasMaxLength(50)
                                .IsRequired();

            modelBuilder.Entity<Product>().Property(p => p.Name)
                    .HasMaxLength(50)
                    .IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Price)
                    .IsRequired();


            modelBuilder.Entity<Position>().Property(p => p.Name)
                                .HasMaxLength(50)
                                .IsRequired();

            modelBuilder.Entity<Shop>().Property(s => s.Name)
                                            .HasMaxLength(50)
                                            .IsRequired();
            modelBuilder.Entity<Shop>().Property(s => s.Address)
                                            .HasMaxLength(150)
                                            .IsRequired();

            modelBuilder.Entity<Worker>().Property(w => w.Name)
                                            .HasMaxLength(50)
                                            .IsRequired();
            modelBuilder.Entity<Worker>().Property(w => w.Surname)
                                            .HasMaxLength(50)
                                            .IsRequired();
            modelBuilder.Entity<Worker>().Ignore(w => w.FullName);
            modelBuilder.Entity<Worker>().Property(w => w.Salary).IsRequired();
            modelBuilder.Entity<Worker>().Property(w => w.Email).IsRequired();
            modelBuilder.Entity<Worker>().Property(w => w.PhoneNumber)
                                            .HasMaxLength(50)
                                            .IsRequired();

            //Relationships
            modelBuilder.Entity<Worker>().HasOne(w => w.Shop)
                                         .WithMany(s => s.Workers);            
            modelBuilder.Entity<Worker>().HasOne(w => w.Position)
                                         .WithMany(p => p.Workers);             
            modelBuilder.Entity<Shop>().HasMany(s => s.Products)
                                         .WithMany(p => p.Shops);              
            modelBuilder.Entity<Shop>().HasOne(s => s.City)
                                         .WithMany(c => c.Shops);             
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                         .WithMany(c => c.Products);            
            modelBuilder.Entity<City>().HasOne(c => c.Country)
                                         .WithMany(c => c.Cities);  
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Worker> Workers { get; set; }

    }
}

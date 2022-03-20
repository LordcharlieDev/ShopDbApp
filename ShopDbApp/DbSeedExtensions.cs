using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDbApp
{
    public static class DbSeedExtensions
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country { Id = 1, Name = "USA"},
                new Country { Id = 2, Name = "Ukraine"},
                new Country { Id = 3, Name = "Poland"}
            });
        }
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Technical"},
                new Category() { Id = 2, Name = "Household"},
            });
        }
        public static void SeedPosition(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(new[] 
            {
                new Position() { Id = 1, Name = "Manager"},
                new Position() { Id = 2, Name = "Administrator"},
                new Position(){ Id = 3, Name = "Adviser"}
            });
        }

        public static void SeedCity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Kyiv"},
                new City() { Id = 1, Name = "Rivne"},
                new City() { Id = 1, Name = "Krakiv"}
            });
        }
    }
}

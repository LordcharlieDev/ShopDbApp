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
        public ShopDb()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SEGB2UP;Initial catalog = ShopDb;Integrated Security=True;Connect Timeout=5;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }

    }
}

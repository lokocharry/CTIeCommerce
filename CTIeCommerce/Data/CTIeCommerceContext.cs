using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CTIeCommerce.Models;

namespace CTIeCommerce.Data
{
    public class CTIeCommerceContext : DbContext
    {
        public CTIeCommerceContext (DbContextOptions<CTIeCommerceContext> options)
            : base(options)
        {
        }

        public DbSet<CTIeCommerce.Models.Product> Products { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}

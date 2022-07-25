using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCOnline_Nursery.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Conn")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductDemo>()
                .HasIndex(x => x.SKU_NO)
                .IsUnique();
        }
        public DbSet<ProductDemo> productDemos { get; set; }
        public DbSet<CategoriesDemo> categoriesDemos { get; set; }
    }
}
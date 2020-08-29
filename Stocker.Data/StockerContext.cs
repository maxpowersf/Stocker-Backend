using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocker.Data
{
    public class StockerContext : DbContext
    {
        public StockerContext(DbContextOptions<StockerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Entities.Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
            });

            builder.Entity<Entities.Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.Category)
                    .WithMany()
                    .HasForeignKey(e => e.CategoryId);
            });
        }

        public virtual DbSet<Entities.Categories> Categories { get; set; }

        public virtual DbSet<Entities.Products> Products { get; set; }
    }
}

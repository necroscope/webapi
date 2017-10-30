namespace WebAPI_Basics.Models
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class PTC : DbContext
  {
    public PTC()
        : base("name=PTC") {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Entity<Product>()
          .Property(e => e.Price)
          .HasPrecision(19, 4);
    }
  }
}
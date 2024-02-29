using Microsoft.EntityFrameworkCore;
using AdventureWorksAPI.Models; // Replace with your actual namespace

public class MySampleDbContext : DbContext
{
    public MySampleDbContext(DbContextOptions<MySampleDbContext> options)
        : base(options)
    {
    }

  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable("Product", schema: "SalesLT");
    }

  public DbSet<Product> Products { get; set; }
 
}
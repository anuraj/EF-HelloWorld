using Microsoft.EntityFrameworkCore;

namespace EF_HelloWorld.Data;

public class HelloWorldDbContext : DbContext
{
    public HelloWorldDbContext(DbContextOptions options) : base(options)
    {
    }

    protected HelloWorldDbContext()
    {
    }
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<NewProduct> NewProducts { get; set; } = null!;
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Product 1", Description = "Description 1" });
    //     modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Product 2", Description = "Description 2" });
    // }
}

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}

public class NewProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
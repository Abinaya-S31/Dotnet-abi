using Microsoft.EntityFrameworkCore;
using System;  // Optional: only if you later add logging or timestamps

public class AppDbContext : DbContext
{
    // This will create a table named "Products"
    public DbSet<Product> Products { get; set; }

    // Configure connection string to LocalDB (default for VS)
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RetailDB;Trusted_Connection=True;");
    }

    // Optional: Model customization (you can leave this out for now)
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     // Customize table names, constraints, etc.
    // }
}

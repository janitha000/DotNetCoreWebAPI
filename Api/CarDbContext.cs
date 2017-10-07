using Microsoft.EntityFrameworkCore;

public class CarDbContext : DbContext
{
    public DbSet<CarBrand> CarBrand { get; set; }
    public DbSet<CarType> CarType { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=./Cars.db");
    }
}
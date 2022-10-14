using Microsoft.EntityFrameworkCore;
using Source.Models;

namespace Source.Repositories.Contexts;

public class MyDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Homework");

        // Configuration
        // Configuration.Json

        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Student>? Students { get; set; }
}

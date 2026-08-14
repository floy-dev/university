using lab4.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab4.Context;

public class DefaultContext : DbContext
{
    public DbSet<Visitor> Visitors { get; set; }
    
    public DbSet<Room> Rooms { get; set; }
    
    public DefaultContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=hotel_lab_4;Username=postgres;Password=password");
    }
}

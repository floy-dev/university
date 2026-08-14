using Microsoft.EntityFrameworkCore;

namespace lab2.Context;

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
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=hotel_lab_2;Username=user;Password=password");
    }
}

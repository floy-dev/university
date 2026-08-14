using lab3.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3.Context;

public class DefaultContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public DbSet<Phone> Phones { get; set; }
    
    public DbSet<Visitor> Visitors { get; set; }
    
    public DbSet<Room> Rooms { get; set; }

    
    public DefaultContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=football;Username=user;Password=password");
    }
}

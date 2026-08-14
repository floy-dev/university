using lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace lab5.Context;

public class DefaultContext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Room> Rooms { get; set; }
    
    public DefaultContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=hotel_lab_5;Username=user;Password=password");
    }
}

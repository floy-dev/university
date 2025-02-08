using lab3.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3.Context;

public class PhoneContext : DbContext
{
    public DbSet<Phone> Phones { get; set; }
    
    public PhoneContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=football;Username=user;Password=password");
    }
}

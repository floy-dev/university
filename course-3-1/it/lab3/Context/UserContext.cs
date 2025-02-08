using Microsoft.EntityFrameworkCore;

namespace lab3.Context;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public UserContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=football;Username=user;Password=password");
    }
}

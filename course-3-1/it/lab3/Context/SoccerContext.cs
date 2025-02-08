using lab3.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3.Context;

public class SoccerContext: DbContext
{
    public DbSet<Player> Players { get; set; }
    
    public DbSet<Team> Teams { get; set; }
    
    public SoccerContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5499;Database=football;Username=user;Password=password");
    }
}
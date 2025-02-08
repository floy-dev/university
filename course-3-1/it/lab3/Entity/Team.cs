namespace lab3.Entity;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Player> Players { get; set; }
    
    public Team()
    {
        Players = new List<Player>();
    }
}
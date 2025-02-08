namespace lab3.Entity;

public class Player
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    public string Position { get; set; }
    
    public int Age { get; set; }
    public ICollection<Team> Teams { get; set; }
    public Player()
    {
        Teams = new List<Team>();
    }
}
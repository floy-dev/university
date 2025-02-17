namespace lab4.Entity;

public class Room
{
    public int Id { get; set; }
    
    public string Number { get; set; }
    
    public string Floor { get; set; }
    
    public float Price { get; set; }
    public ICollection<Visitor> Visitors { get; set; }
    
    public Room()
    {
        Visitors = new List<Visitor>();
    }
}
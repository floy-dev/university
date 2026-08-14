namespace lab3.Entity;

public class Visitor
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Phone { get; set; }

    public int Age { get; set; }
    
    public ICollection<Room> Rooms { get; set; }
    
    public Visitor()
    {
        Rooms = new List<Room>();
    }
}
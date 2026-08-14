namespace lab4.Entity;

public class Visitor
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Phone { get; set; }

    public int Age { get; set; }
    
    public int RoomId { get; set; }
    public Room Room { get; set; }
}
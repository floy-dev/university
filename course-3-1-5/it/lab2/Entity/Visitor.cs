namespace lab2;

public class Visitor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public int? RoomId { get; set; }
    
    public Room? Room { get; set; }
}
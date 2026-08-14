namespace lab5.Models;

public class Booking
{
    public int Id { get; set; }

    public string VisitorFirtsName { get; set; } 
    
    public string VisitorLastName { get; set; } 
    
    public string VisitorPassport { get; set; } 
    
    public int RoomId { get; set; }
    public Room Room { get; set; }
    
    public DateTime BookingStartDate { get; set; } = DateTime.Now;
}
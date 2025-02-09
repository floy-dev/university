namespace lab5.Request;

public class CreateBookingRequest
{
    public string VisitorFirtsName { get; set; } 
    
    public string VisitorLastName { get; set; } 
    
    public string VisitorPassport { get; set; } 
    
    public int RoomId { get; set; }
}
using lab1.Handler;

namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        Visitor visitor1 = new Visitor("Ivan", "79040992214", 2);
        Visitor visitor2 = new Visitor();
        Visitor visitor3 = new Visitor("Svetlana", "79040992632", 3);

        Hotel hotel = new Hotel();

        OnDeleteHandler onDeleteHandler = new OnDeleteHandler();
        hotel.OnDelete += onDeleteHandler.Message;
        
        OnAddHandler onAddHandler = new OnAddHandler();
        hotel.OnAdd += onAddHandler.Message;
        
        hotel.AddVisitor(visitor1);
        
        hotel.DeleteByName("Dmitry");
        
        hotel.AddVisitor(visitor2);
        hotel.AddVisitor(visitor3);
        hotel.AddVisitor(visitor1);

        List<Visitor> result = hotel.FindAllByName("Ivan");
        foreach (Visitor visitor in result)
        {
            visitor.GetInformation();
        }
        
        Console.ReadKey();
    }
}
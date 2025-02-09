using lab2.Context;

namespace lab2;

public class Program
{
    static void Main(string[] args)
    {
        using DefaultContext db = new DefaultContext();

        // Init(db);

        FindByName(db, "Dmitry");
        
        RemoveByName(db, "Dmitry");
    }

    static void FindByName(DefaultContext db, string name)
    {
        Visitor? visitor = db.Visitors
            .FirstOrDefault(b => b.Name == "Dmitry");

        Console.WriteLine(visitor is not null ? $"{visitor.Id}: {visitor.Name}" : "Пользователь не найден");
    }
    
    static void RemoveByName(DefaultContext db, string name)
    {
        Visitor? visitor = db.Visitors
            .FirstOrDefault(b => b.Name == "Dmitry");

        if (visitor == null)
        {
            Console.WriteLine("Пользователь не найден");
            
            return;
        }
        
        Console.WriteLine($"Пользователь {visitor.Id}: {visitor.Name} удален");
        db.Visitors.Remove(visitor);
        
        db.SaveChanges();
    }
    
    static void Init(DefaultContext db)
    {
        Room room1 = new Room { Number = "1", Floor = "1", Price = 1000};
        Room room2 = new Room { Number = "2", Floor = "2", Price = 2000};
        
        db.Rooms.AddRange(room1, room2);
        
        Visitor visitor1 = new Visitor { Name = "Dmitry", Phone = "123456" };
        Visitor visitor2 = new Visitor { Name = "Ivan", Phone = "123456"};

        db.Visitors.AddRange(visitor1, visitor2);
        
        room1.Visitors.Add(visitor1);
        room2.Visitors.Add(visitor2);
        
        db.SaveChanges();
    }
}

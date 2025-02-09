using lab3.Context;
using lab3.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3;

public class Program
{
    static void Main(string[] args)
    {
        Users();
        Hotels();
    }

    static void Users()
    {
        using DefaultContext db = new DefaultContext();

        User user1 = new User { Name = "Tom", Age = 33 };
        User user2 = new User { Name = "Alice", Age = 26 };

        db.Users.AddRange(user1, user2);
        // db.SaveChanges();

        var users = db.Users.ToList();
        Console.WriteLine("Список пользователей:");
        foreach (User user in users)
        {
            Console.WriteLine("{0}.{1} - {2}", user.Id, user.Name, user.Age);
        }
    }

    static void Hotels()
    {
        using DefaultContext db = new DefaultContext();

        Room room1 = new Room { Number = "01", Floor = "1", Price = 1000};
        Room room2 = new Room { Number = "02", Floor = "1", Price = 2500 };
        
        // db.SaveChanges();
        
        Visitor visitor1 = new Visitor
        {
            Name = "Dmitry", Age = 22, Phone = "7904235231"
        };
        Visitor visitor2 = new Visitor
        {
            Name = "Ivan", Age = 21, Phone = "7905313212"
        };
        Visitor visitor3 = new Visitor
        {
            Name = "Svetlana", Age = 23, Phone = "79085452342"
        };
        db.Visitors.AddRange(new List<Visitor> { visitor1, visitor2, visitor3 });
        
        room1.Visitors.Add(visitor1);
        room2.Visitors.Add(visitor2);
        
        db.Rooms.Add(room1);
        db.Rooms.Add(room2);
        
        db.SaveChanges();

        Print(db);
        
        Edit(db, room2);
        Print(db);
        
        Delete(db);
        Print(db);
    }

    static void Edit(DefaultContext db, Room room)
    {
        room.Floor = "2";
        
        db.SaveChanges();
    }
    
    static void Delete(DefaultContext db)
    {
        Visitor deleteVisitor = db.Visitors.First(p => p.Name == "Dmitry");
        db.Visitors.Remove(deleteVisitor);
        
        Room deleteRoom = db.Rooms.First();
        db.Rooms.Remove(deleteRoom);
        
        db.SaveChanges();
    }

    static void Print(DefaultContext db)
    {
        foreach (Room room in db.Rooms.Include(t => t.Visitors).ToList())
        {
            Console.WriteLine($"Комната: этаж {room.Floor}, номер {room.Number}");
            
            foreach (Visitor visitor in room.Visitors)
            {
                Console.WriteLine($"{visitor.Name} - {visitor.Age}, номер телефона {visitor.Phone}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("----------------------");
    }
}

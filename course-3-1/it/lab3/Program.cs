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
        Room room3 = new Room { Number = "03", Floor = "1", Price = 2500 };
        Room room4 = new Room { Number = "11", Floor = "2", Price = 3500 };
        Room room5 = new Room { Number = "12", Floor = "2", Price = 4500 };
        
        Visitor visitor1 = new Visitor
        {
            Name = "Dmitry Anatolievich", Age = 22, Phone = "7904235231"
        };
        Visitor visitor2 = new Visitor
        {
            Name = "Ivan Akulbdyanov", Age = 21, Phone = "7905313212"
        };
        Visitor visitor3 = new Visitor
        {
            Name = "Svetlana Poymenova", Age = 23, Phone = "7512452342"
        };
        Visitor visitor4 = new Visitor
        {
            Name = "Alexandra Talachixova", Age = 23, Phone = "725852512342"
        };
        Visitor visitor5 = new Visitor
        {
            Name = "Prosto Pavel", Age = 24, Phone = "77454512542"
        };
        
        // db.Visitors.AddRange(new List<Visitor> { visitor1, visitor2, visitor3, visitor4, visitor5 });
        //
        // room1.Visitors.Add(visitor1);
        // room2.Visitors.Add(visitor2);
        // room2.Visitors.Add(visitor3);
        // room3.Visitors.Add(visitor4);
        // room5.Visitors.Add(visitor5);
        //
        // db.Rooms.Add(room1);
        // db.Rooms.Add(room2);
        // db.Rooms.Add(room3);
        // db.Rooms.Add(room4);
        // db.Rooms.Add(room5);
        
        // db.SaveChanges();

        // Print(db);
        
        Room editRoom = db.Rooms.First(p => p.Number == "01");
        
        Edit(db, editRoom);
        Print(db);
        
        Delete(db);
        Print(db);
    }

    static void Edit(DefaultContext db, Room room)
    {
        room.Floor = "8";
        
        db.SaveChanges();
    }
    
    static void Delete(DefaultContext db)
    {
        Visitor deleteVisitor = db.Visitors.First(p => p.Name == "Dmitry Anatolievich");
        db.Visitors.Remove(deleteVisitor);
        
        Room deleteRoom = db.Rooms.First(p => p.Number == "02");
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

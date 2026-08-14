using lab2.Context;

namespace lab2;

public class Program
{
    static void Main(string[] args)
    {
        using DefaultContext db = new DefaultContext();

        FindByName(db, "Dmitry Anatolievich");
        
        RemoveByName(db, "Dmitry Anatolievich");
        
        RemoveByName(db, "Dmitry Anatolievich");
    }

    static void FindByName(DefaultContext db, string name)
    {
        Visitor? visitor = db.Visitors
            .FirstOrDefault(b => b.Name == name);

        Console.WriteLine(visitor is not null ? $"{visitor.Id}: {visitor.Name}" : "Пользователь не найден");
    }
    
    static void RemoveByName(DefaultContext db, string name)
    {
        Visitor? visitor = db.Visitors
            .FirstOrDefault(b => b.Name == name);

        if (visitor == null)
        {
            Console.WriteLine("Пользователь не найден");
            
            return;
        }
        
        Console.WriteLine($"Пользователь {visitor.Id}: {visitor.Name} удален");
        db.Visitors.Remove(visitor);
        
        db.SaveChanges();
    }
}

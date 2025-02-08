using lab3.Context;
using lab3.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3;

public class Program
{
    static void Main(string[] args)
    {
        Users();
        Soccers();
    }

    static void Users()
    {
        using UserContext db = new UserContext();

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

    static void Soccers()
    {
        using SoccerContext db = new SoccerContext();

        Team team1 = new Team { Name = "Барселона" };
        Team team2 = new Team { Name = "Реал Мадрид" };
        
        // db.SaveChanges();
        
        Player pl1 = new Player
        {
            Name = "Роналду", Age = 31, Position = "Нападающий"
        };
        Player pl2 = new Player
        {
            Name = "Месси", Age = 28, Position = "Нападающий"
        };
        Player pl3 = new Player
        {
            Name = "Хави", Age = 34, Position = "Полузащитник"
        };
        db.Players.AddRange(new List<Player> { pl1, pl2, pl3 });
        
        team1.Players.Add(pl1);
        team2.Players.Add(pl2);
        
        db.Teams.Add(team1);
        db.Teams.Add(team2);
        
        db.SaveChanges();

        Print(db);
        
        Edit(db, team2, pl3);
        Print(db);
        
        Delete(db);
        Print(db);
    }

    static void Edit(SoccerContext db, Team team, Player player)
    {
        team.Name = "Реал М.";
        
        // player.Team = team;
        
        db.SaveChanges();
    }
    
    static void Delete(SoccerContext db)
    {
        Player deletePlayer = db.Players.First(p => p.Name == "Роналду");
        db.Players.Remove(deletePlayer);
        
        Team deleteTeam = db.Teams.First();
        db.Teams.Remove(deleteTeam);
        
        db.SaveChanges();
    }

    static void Print(SoccerContext db)
    {
        // foreach (Player player in db.Players.Include(p => p.Team).ToList())
        // {
            // Console.WriteLine("{0} - {1}", player.Name, player.Team != null ? player.Team.Name : "");
        // }

        // Console.WriteLine();
        
        foreach (Team team in db.Teams.Include(t => t.Players).ToList())
        {
            Console.WriteLine("Команда: {0}", team.Name);
            
            foreach (Player pl in team.Players)
            {
                Console.WriteLine("{0} - {1}", pl.Name, pl.Position);
            }

            Console.WriteLine();
        }

        Console.WriteLine("----------------------");
    }
}

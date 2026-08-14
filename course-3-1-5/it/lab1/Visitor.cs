namespace lab1;

public class Visitor
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public int Days { get; set; }

    public Visitor(string name, string phone, int days)
    {
        Name = name;
        Phone = phone;
        Days = days;
    }

    public Visitor()
    {
        Name = "Dmitry";
        Phone = "79040992352";
        Days = 1;
    }

    public void GetInformation()
    {
        Console.WriteLine(
            "Посетитель '{0}' номер телефона {1}, количество забронированых дней: {2}",
            Name,
            Phone,
            Days.ToString()
        );
    }
}
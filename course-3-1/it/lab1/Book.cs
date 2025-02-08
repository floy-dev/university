namespace lab1;

public class Book
{
    private string _name;
    private string _author;
    private int _year;
    private int _quantity;
    
    public Book(string name, string author, int year, int quantity)
    {
        _name = name;
        _author = author;
        _year = year;
        _quantity = quantity;
    }

    public Book()
    {
        _name = "Евгений Онегин";
        _author = "А.С. Пушкин";
        _year = 1833;
        _quantity = 1;
    }
    
    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    { 
        this._quantity = quantity;
    }

    public string GetAuthor()
    {
        return _author;
    }
    
    public string GetName()
    {
        return _name;
    }

    public void GetInformation()
    {
        Console.WriteLine(
            "Книга '{0}' автор {1} была издана в {2} году, количество экземпляров: {3}",
            _name,
            _author,
            _year,
            _quantity
        );
    }
}
using lab1.Handler;

namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Война и мир", "Л.Н. Толстой", 1869, 4);
        Book book2 = new Book();
        Book book3 = new Book("Филипок", "Л.Н. Толстой", 1875, 2);

        Library library = new Library();

        OnDeleteHandler onDeleteHandler = new OnDeleteHandler();
        library.OnDelete += onDeleteHandler.Message;
        
        OnAddHandler onAddHandler = new OnAddHandler();
        library.OnAdd += onAddHandler.Message;
        
        library.AddBook(book1);
        
        library.DeleteByAuthor("Л.Н. Толстой");
        
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book1);

        List<Book> result = library.FindAllByAuthor("Л.Н. Толстой");
        foreach (Book book in result)
        {
            book.GetInformation();
        }
        
        Console.ReadKey();

    }
}
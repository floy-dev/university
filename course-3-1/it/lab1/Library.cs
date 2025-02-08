namespace lab1;

public class Library
{
    public delegate void DeleteMethodContainer();
    public event DeleteMethodContainer OnDelete = null!;
    
    public delegate void AddMethodContainer();
    public event AddMethodContainer OnAdd = null!;
    
    public readonly List<Book> Books = [];
    
    private string _filterAuthor = "";
    private string _filterName = "";
    
    public void AddBook(Book book)
    {
        int? foundBookIndex = FindByAuthorAndName(book.GetAuthor(), book.GetName());
        
        if (foundBookIndex == -1)
        {
            Books.Add(book);

            OnAdd();
            
            return;
        }
        
        Book foundBook = Books[foundBookIndex.Value];
            
        foundBook.SetQuantity(foundBook.GetQuantity() + book.GetQuantity());

        OnAdd();
    }
    
    public void DeleteByAuthor(string author)
    {
        _filterAuthor = author;
        
        Books.RemoveAll(PredicateAuthor);

        OnDelete();
    }
    
    public List<Book> FindAllByAuthor(string author)
    {
        _filterAuthor = author;

        return Books.FindAll(PredicateAuthor);
    }
    
    public int FindByAuthorAndName(string author, string name)
    {
        _filterAuthor = author;
        _filterName = name;

        return Books.FindIndex(PredicateAuthorAndName);
    }
    
    private bool PredicateAuthorAndName(Book book)
    {
        return book.GetAuthor() == _filterAuthor && book.GetName() == _filterName;
    }

    private bool PredicateAuthor(Book book)
    {
        return book.GetAuthor() == _filterAuthor;
    }
}
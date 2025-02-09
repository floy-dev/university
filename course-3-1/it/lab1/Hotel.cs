namespace lab1;

public class Hotel
{
    public delegate void DeleteMethodContainer();
    public event DeleteMethodContainer OnDelete = null!;
    
    public delegate void AddMethodContainer();
    public event AddMethodContainer OnAdd = null!;
    
    public readonly List<Visitor> Visitors = [];
    
    private string _filterName = "";
    private string _filterPhone = "";
    
    public void AddVisitor(Visitor visitor)
    {
        int? foundVisitorIndex = FindByNameAndPhone(visitor.Name, visitor.Phone);
        
        if (foundVisitorIndex == -1)
        {
            Visitors.Add(visitor);

            OnAdd();
            
            return;
        }
        
        Visitor foundVisitor = Visitors[foundVisitorIndex.Value];
            
        foundVisitor.Days += visitor.Days;

        OnAdd();
    }
    
    public void DeleteByName(string name)
    {
        _filterName = name;
        
        Visitors.RemoveAll(PredicateName);

        OnDelete();
    }
    
    public List<Visitor> FindAllByName(string name)
    {
        _filterName = name;

        return Visitors.FindAll(PredicateName);
    }
    
    public int FindByNameAndPhone(string name, string phone)
    {
        _filterName = name;
        _filterPhone = phone;

        return Visitors.FindIndex(PredicateNameAndPhone);
    }
    
    private bool PredicateNameAndPhone(Visitor visitor)
    {
        return visitor.Name == _filterName && visitor.Phone == _filterPhone;
    }

    private bool PredicateName(Visitor visitor)
    {
        return visitor.Name == _filterName;
    }
}
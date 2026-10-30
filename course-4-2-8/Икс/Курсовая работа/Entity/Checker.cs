namespace Checkers.Entity;

public class Checker
{
    public bool IsWhite { get; }
    public bool IsQueen { get; set; }

    public Checker(bool isWhite, bool isQueen)
    {
        IsWhite = isWhite;
        IsQueen = isQueen;
    }
}

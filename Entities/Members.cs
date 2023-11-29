namespace LibraryManagementSystem.Entities;

public class Members
{
    private string _name { get; set; }
    private string _surname { get; set; }
    private int _memberNo { get; set; }

    private static int _counter;
    
    private List<int> _borrowedBooks { get; set; } = new List<int>();

    public Members(string name, string surname)
    {
        this._name = name;
        this._surname = surname;
        _memberNo = _counter;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetSurname()
    {
        return _surname;
    }

    public void SetSurname(string surname)
    {
        _surname = surname;
    }

    public int GetMemberNo()
    {
        return _memberNo;
    }

    public List<int> GetBorrowedBooks()
    {
        return _borrowedBooks;
    }

    public void AddBorrowedBook(int bookId)
    {
        _borrowedBooks.Add(bookId);
    }
}
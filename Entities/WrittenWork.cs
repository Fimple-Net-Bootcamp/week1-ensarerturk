namespace LibraryManagementSystem.Entities;

public class WrittenWork
{
    private string _name { get; set; }
    private string _author { get; set; }
    private int _yearOfPublic { get; set; }
    private int _id { get; set; }

    private static int _counter;

    public WrittenWork(string name, string author, int yearOfPublic)
    {
        _name = name;
        _author = author;
        _yearOfPublic = yearOfPublic;
        _id = _counter++;
    }
    
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetYearOfPublic()
    {
        return _yearOfPublic;
    }

    public void SetYearOfPublic(int yearOfPublic)
    {
        _yearOfPublic = yearOfPublic;
    }

    public int GetId()
    {
        return _id;
    }
}
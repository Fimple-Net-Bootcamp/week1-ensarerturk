using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Entities;

public class Book : WrittenWork
{
    public Book(string name, string author, int yearOfPublic) : base(name, author, yearOfPublic)
    {
    }
    
}
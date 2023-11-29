using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services;

public class LibraryService : ILibraryService
{
    private readonly ILibraryRepository libraryRepository;

    public LibraryService(ILibraryRepository libraryRepository)
    {
        this.libraryRepository = libraryRepository;
    }

    public void AddBook(Book book)
    {
        libraryRepository.BookAdding(book);
    }

    public void DeleteBook(int bookId)
    {
        libraryRepository.BookDeleting(bookId);
    }

    public void AddMember(Members member)
    {
        libraryRepository.MemberAdding(member);
    }

    public void DeleteMember(int memberNo)
    {
        libraryRepository.MemberDeleting(memberNo);
    }

    public void LendBook(int bookId, int memberNo)
    {
        libraryRepository.BookLending(bookId, memberNo);
    }

    public void ReturnBook(int bookId, int memberNo)
    {
        libraryRepository.BookReturn(bookId, memberNo);
    }

    public void ShowBorrowStatus(int bookId)
    {
        libraryRepository.ShowBorrowStatus(bookId);
    }

    public void PrintItems()
    {
        libraryRepository.PrintBooks();
        libraryRepository.PrintMembers();
    }
}
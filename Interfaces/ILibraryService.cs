using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Interfaces;

public interface ILibraryService
{
    void AddBook(Book book);
    void DeleteBook(int bookId);
    void AddMember(Members member);
    void DeleteMember(int memberNo);
    void LendBook(int bookId, int memberNo);
    void ReturnBook(int bookId, int memberNo);
    void ShowBorrowStatus(int bookId);
    void PrintItems();
}
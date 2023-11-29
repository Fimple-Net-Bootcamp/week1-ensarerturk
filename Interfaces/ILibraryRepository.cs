using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Interfaces;

public interface ILibraryRepository
{
    void BookAdding(Book book);
    void BookDeleting(int bookId);
    void MemberAdding(Members member);
    void MemberDeleting(int memberNo);
    void BookLending(int bookId, int memberNo);
    void BookReturn(int bookId, int memberNo);
    void ShowBorrowStatus(int bookId);
    void PrintBooks();
    void PrintMembers();
}
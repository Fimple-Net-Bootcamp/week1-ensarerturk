using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services;

public class LibraryRepository : ILibraryRepository
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Members> _membersList = new List<Members>();

        public void BookAdding(Book book)
        {
            _books.Add(book);
        }

        public void BookDeleting(int bookId)
        {
            Book deletedBook = _books.Find(b => b.GetId() == bookId);
            if (deletedBook != null)
            {
                _books.Remove(deletedBook);
            }
        }

        public void MemberAdding(Members members)
        {
            _membersList.Add(members);
        }

        public void MemberDeleting(int memberNo)
        {
            Members deletedMembers = _membersList.Find(m => m.GetMemberNo() == memberNo);
            if (deletedMembers != null)
            {
                _membersList.Remove(deletedMembers);
            }
        }

        public void BookLending(int bookId, int memberNo)
        {
            Book lendingBook = _books.Find(b => b.GetId() == bookId);
            Members lendingMembers = _membersList.Find(m => m.GetMemberNo() == memberNo);

            if (lendingBook != null && lendingMembers != null)
            {
                lendingMembers.GetBorrowedBooks().Add(bookId);
                Console.WriteLine($"The book {lendingBook.GetName()} has been lent to member {lendingMembers.GetName()} {lendingMembers.GetSurname()}.");
            }
            else
            {
                Console.WriteLine("No book or member found.");
            }
        }

        public void BookReturn(int bookId, int memberNo)
        {
            Book lendingBook = _books.Find(b => b.GetId() == bookId);
            Members lendingMembers = _membersList.Find(m => m.GetMemberNo() == memberNo);

            if (lendingBook != null && lendingMembers != null && lendingMembers.GetBorrowedBooks().Contains(bookId))
            {
                lendingMembers.GetBorrowedBooks().Remove(bookId);
                Console.WriteLine($"The book named {lendingBook.GetName()} was returned by member {lendingMembers.GetName()} {lendingMembers.GetSurname()}.");
            }
            else
            {
                Console.WriteLine("Book or member not found or book not checked out.");
            }
        }

        public void ShowBorrowStatus(int bookId)
        {
            Book book = _books.Find(b => b.GetId() == bookId);

            if (book != null)
            {
                foreach (var member in _membersList)
                {
                    if (member.GetBorrowedBooks().Contains(bookId))
                    {
                        Console.WriteLine($"Book '{book.GetName()}', Member No: {member.GetMemberNo()}, Name: {member.GetName()} is lent to {member.GetSurname()}.\n");
                        return;
                    }
                }

                Console.WriteLine($"Book '{book.GetName()}' is not currently on anyone's loan.\n");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void PrintBooks()
        {
            Console.WriteLine("Books :");
            foreach (var book in _books)
            {
                Console.WriteLine($"ID: {book.GetId()}, Name: {book.GetName()}, Author: {book.GetAuthor()}, Publication Year: {book.GetYearOfPublic()}");
            }
        }

        public void PrintMembers()
        {
            Console.WriteLine("\nMembers :");
            foreach (var members in _membersList)
            {
                Console.WriteLine($"Member No: {members.GetMemberNo()}, First Name: {members.GetName()}, Last Name: {members.GetSurname()}\n");
            }
        }
    }
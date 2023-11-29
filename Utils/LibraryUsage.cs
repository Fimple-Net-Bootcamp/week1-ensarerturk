using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Utils;

public class LibraryUsage
{
    private readonly ILibraryService libraryService;

    public LibraryUsage(ILibraryService libraryService)
    {
        this.libraryService = libraryService;
    }

    public void RunLibrary()
    {
        while (true)
        {
            DisplayMenu();

            Console.Write("Your selection: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DeleteBook();
                    break;
                case "3":
                    AddMember();
                    break;
                case "4":
                    DeleteMember();
                    break;
                case "5":
                    LendBook();
                    break;
                case "6":
                    ReturnBook();
                    break;
                case "7":
                    ListItems();
                    break;
                case "8":
                    LendingQuery();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Delete Book");
        Console.WriteLine("3. Add Member");
        Console.WriteLine("4. Delete Member");
        Console.WriteLine("5. Lend Book");
        Console.WriteLine("6. Return Book");
        Console.WriteLine("7. List");
        Console.WriteLine("8. Lending Query");
        Console.WriteLine("9. Exit");
    }

    private void LendingQuery()
    {
        Console.Write("Book ID   : ");
        int bookId = GetIntInput();
        Console.Write("Member No : ");
        int memberNo = GetIntInput();

        libraryService.ShowBorrowStatus(bookId);
    }

    private void ReturnBook()
    {
        Console.Write("Book ID   : ");
        int bookId = GetIntInput();
        Console.Write("Member No : ");
        int memberNo = GetIntInput();

        libraryService.ReturnBook(bookId, memberNo);
    }

    private void LendBook()
    {
        Console.Write("Book ID   : ");
        int bookId = GetIntInput();
        Console.Write("Member No : ");
        int memberNo = GetIntInput();

        libraryService.LendBook(bookId, memberNo);
    }

    private void DeleteMember()
    {
        Console.Write("Member No to be deleted: ");
        int deletedMemberNo = GetIntInput();

        libraryService.DeleteMember(deletedMemberNo);
        Console.WriteLine("Member deleted.\n");
    }

    private void AddMember()
    {
        Console.Write("Member Name    : ");
        string memberName = Console.ReadLine();
        Console.Write("Member Surname : ");
        string memberSurname = Console.ReadLine();

        Members member = new Members(memberName, memberSurname);
        libraryService.AddMember(member);

        Console.WriteLine("Member added.\n");
    }

    private void DeleteBook()
    {
        Console.Write("Book ID to delete: ");
        int deleteBookId = GetIntInput();

        libraryService.DeleteBook(deleteBookId);

        Console.WriteLine("Book deleted.\n");
    }

    private void AddBook()
    {
        Console.Write("Book Name: ");
        string bookName = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Year of publication: ");
        int yearOfPublication = GetIntInput();

        Book book = new Book(bookName, author, yearOfPublication);
        libraryService.AddBook(book);

        Console.WriteLine("Book added.\n");
    }

    private int GetIntInput()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    private void ListItems()
    {
        libraryService.PrintItems();
    }
}
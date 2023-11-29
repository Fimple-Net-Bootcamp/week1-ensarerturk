using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Utils;



class Program
{
    static void Main()
    {
        ILibraryRepository libraryRepository = new LibraryRepository();
        ILibraryService libraryService = new LibraryService(libraryRepository);
        LibraryUsage libraryUsage = new LibraryUsage(libraryService);
        
        libraryUsage.RunLibrary();
    }
}

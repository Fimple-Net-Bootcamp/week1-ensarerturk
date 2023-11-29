# Library Management System

This project includes a simple application for library management. Object Oriented Programming (OOP) rules and SOLID principles are used in the project.

## Project Structure

- **Entities:** The basic entity classes in the project are located here.
    - `WrittenWork`: Base class containing common properties of books and other written works.
    - `Book`: The class representing books, derived from `WrittenWork`.
    - `Members`: Class representing library members.

- **Interfaces:** The interfaces in the project are located here.
    - `ILibraryService`: Defines the service methods that perform library operations.
    - `ILibraryRepository`: Defines the repository methods that store library data.

- **Services:** Service classes that implement interfaces are found here.
    - `LibraryService`: Implements the `ILibraryService` interface, performs library operations.

- **Repository:** Service classes that implement interfaces are found here.
    - `LibraryRepository`: Implements the `ILibraryRepository` interface, stores and manages library data.

- **Utils:** Helper classes and other code shared by the application are located here.
    - `LibraryUsage`: The class that provides the library application's user interface.

- **Program.cs:** The main program file that is the starting point of the application.

## How to use it

The application contains a loop to perform library operations. Various options are presented to the user and the user chooses and performs the relevant operation.

- Select "1" to add a book.
- Select "2" to delete a book.
- Select "3" to add a member.
- Select "4" to delete a member.
- Select "5" to borrow a book.
- Select "6" to return a book.
- Select "7" to list all books and members.
- Select "8" to check the book loan status.
- Select "9" to exit the application.

## OOP Rules and SOLID Principles

This project applies Object Oriented Programming (OOP) rules and SOLID principles as follows:

### OOP Rules

- **Encapsulation:**

The fields inside the classes `(_name, _author, _yearOfPublic, _id, _counter, _name, _surname, _memberNo, _borrowedBooks)` are defined as private and access to these fields is controlled.
There is a private get and set method for each field, thus providing controlled access to the fields.

- **Inheritance:**

The Book class inherits from the `WrittenWork` class. This allows common properties (_name, _author, _yearOfPublic, _id) to be defined in WrittenWork class and used in `Book` class.

- **Polymorphism:**

In accordance with the principle that methods can be used in more than one way, polymorphism can be observed especially in the `BookLending` and `BookReturn` methods in the LibraryRepository class.

- **Abstraction:**

The `ILibraryService` and `ILibraryRepository` interfaces provide abstraction. These interfaces do not contain actual implementations but define a behavior. The `LibraryService` and `LibraryRepository` classes implement these interfaces and provide concrete behavior.

- **Interface Implementation:**

The `ILibraryService` and `ILibraryRepository` interfaces are implemented by their respective classes. This allows a class to contain specific methods by implementing a specific interface.

### SOLID Principles

- **Single Responsibility Principle (SRP):**

Each class and method has a specific responsibility. For example, the `LibraryRepository` class is only responsible for storing and managing library data.

- **Open/Closed Principle (OCP):**

Code is closed to changes and open to extensions. Adding new features or modifying existing ones is possible without changing the existing code. For example, it is not necessary to change the `LibraryUsage` class to add a new operation.

- **Liskov Substitution Principle (LSP):**

Inheritance relationships seem to be used correctly in the project. The `Book` class is derived from the `WrittenWork` class and satisfies this principle.

- **Interface Segregation Principle (ISP):**

The `ILibraryService` and `ILibraryRepository` interfaces contain only their respective methods. Each service or repository implements only the methods it needs.

- **Dependency Inversion Principle (DIP):**

Since dependencies are based on abstractions (interfaces), high-level modules do not depend on low-level modules. For example, the `LibraryUsage` class is dependent on the `ILibraryService` interface, but this dependency is directed to an abstract level.
# atelier-exceptions
A C#.Net Core, console application where we manage books

## Objective

The aim of this workshop challenge is to create a console application for managing a library using C#. The application should include the following features:

## Features to Implement

1. **Define a Book Class**
   - **Properties:**
     - `Id`: A unique identification number for the book (integer).
     - `Title`: The title of the book (string).

2. **Create a Library Class**
   - Contains a list of available books.

3. **Implement Methods in the Library Class**
   - **Add a Book**: Adds a book to the list of available books. If the book already exists (same Id), throw a `BookAlreadyExistsException`.
   - **Remove a Book**: Removes a book from the list of available books. If the book does not exist, throw a `BookNotFoundException`.
   - **Search for a Book by Id**: Searches for a book by its Id. If the book does not exist, throw a `BookNotFoundException`.

4. **Main Program**
   - Instantiate the library and, through a basic input menu, allow the user to add, consult, or remove a book.
   - Handle exceptions to display appropriate error messages to the user.

using Atelier.Models;
using Atelier.Exceptions;
using System;

namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            Console.WriteLine("Welcome dear user, This is the menu selection of our Library");

            while (!exit)
            {
                Console.WriteLine("1 - Add new book");
                Console.WriteLine("2 - Remove a book");
                Console.WriteLine("3 - Find a book");
                Console.WriteLine("Type 'exit' to quit");

                var userSelection = Console.ReadLine();

                if (userSelection?.ToLower() == "exit")
                {
                    exit = true;
                    continue;
                }

                if (int.TryParse(userSelection, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            CreateNewBook(library);
                            break;
                        case 2:
                            RemoveBook(library);
                            break;
                        case 3:
                            FindBook(library);
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'exit' to quit.");
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static void CreateNewBook(Library library)
        {
            Console.WriteLine("Please enter a book title:");
            var bookTitle = Console.ReadLine();

            try
            {
                var book = new Book(bookTitle);

                library.AddBook(book);
                Console.WriteLine("Book added successfully.");
            }
            catch (BookAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        static void RemoveBook(Library library)
        {
            Console.WriteLine("Please enter the book ID to remove:");
            if (int.TryParse(Console.ReadLine(), out int bookId))
            {
                try
                {
                    library.RemoveBook(bookId);
                    Console.WriteLine("Book removed successfully.");
                }
                catch (BookNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid book ID. Please try again.");
            }
        }

        static void FindBook(Library library)
        {
            Console.WriteLine("Please enter the book ID to find:");
            if (int.TryParse(Console.ReadLine(), out int bookId))
            {
                try
                {
                    library.ShowBookById(bookId);
                }
                catch (BookNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid book ID. Please try again.");
            }
        }
    }
}

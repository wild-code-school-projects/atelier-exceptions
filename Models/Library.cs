using Atelier.Exceptions;
using System;
using System.Collections.Generic;

namespace Atelier.Models
{
    internal class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (DoesThisBookExistByTitle(book.Title))
            {
                throw new BookAlreadyExistException($"A book with the title '{book.Title}' already exists.");
            }

            Books.Add(book);
        }

        public void RemoveBook(int id)
        {
            var book = FindBookById(id);
            Books.Remove(book);
        }

        private bool DoesThisBookExistByTitle(string title)
        {
            return Books.Exists(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        private Book FindBookById(int id)
        {
            var book = Books.Find(b => b.Id == id);
            if (book == null)
            {
                throw new BookNotFoundException($"Cannot find the book with ID {id}.");
            }

            return book;
        }

        public void ShowBookById(int id)
        {
            var book = FindBookById(id);
            Console.WriteLine("Information:");
            Console.WriteLine($"ID: {book.Id}");
            Console.WriteLine($"Title: {book.Title}");
        }
    }
}

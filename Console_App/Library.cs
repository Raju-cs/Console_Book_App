using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added to the library.");
        }

        public void RemoveBook(string title)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.Title == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed from the library.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                Console.WriteLine("Listing all books:");
                foreach (var book in books)
                {
                    book.DisplayBook();
                }
            }
        }
    }

}

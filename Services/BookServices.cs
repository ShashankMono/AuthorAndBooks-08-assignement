using AuthorsAndBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Services
{
    internal class BookServices
    {
        public static List<Book> Books = new List<Book>();
        public static string CreateNewBook(int id, string title, int pages, Author author)
        {

            Book book = new Book(id, title, pages, DateTime.Now,author);
            author.Books.Add(book);
            Books.Add(book);
            return "Book Added sucessfully!";
        }

        public static Book FindBook(int id)
        {
            return Books.Where(book => book.Id == id).FirstOrDefault();
        }

        public static string EditBook(Book book, string title, int pages)
        {
            book.Title = title;
            book.Pages = pages;
            book.PublishingDate = DateTime.Now;

            return $"Book with id {book.Id} details updated";

        }

        public static string DisplayAllBooksDetail()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Book book in Books)
            {
                sb.Append(book.ToString() + "\n");
            }
            return sb.ToString();
        }

        public static string DeleteBookDetails(Book book)
        {
            book.Author.Books.Remove(book);
            Books.Remove(book);
            return "Deleted sucessfully!";
        }
    }
}

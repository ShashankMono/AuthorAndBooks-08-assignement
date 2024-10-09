using AuthorsAndBooks.Models;
using AuthorsAndBooks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Presentation
{
    internal class BookMenu
    {
        public static void DisplayBookMenu()
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome to Book management!\n" +
                    $"1.Create new Book\n" +
                    $"2.Edit a Book details\n" +
                    $"3.Display all Book detail\n" +
                    $"4.Delete a book\n" +
                    $"5.Display a book details\n" +
                    $"6.Exit to main menu\n");

                int choice = int.Parse(Console.ReadLine());
                ExceuteBookMenu(choice);
            }
        }

        public static void ExceuteBookMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    TakeDetailsOfBook();
                    break;

                case 2:
                    EditBookDetails();
                    break;

                case 3:
                    DisplayAllBooks();
                    break;

                case 4:
                    DeleteBook();
                    break;

                case 5:
                    DisplayBookDetail();
                    break;

                case 6:
                    MainMenu.DisplayMainMenu();
                    break;

                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }

        public static void TakeDetailsOfBook()
        {
            Author author = AuthorMenu.GetAuthor();
            if (author == null)
            {
                Console.WriteLine("Author Id invalid!");
                return;
            }
            Console.WriteLine("Enter Id of a book:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter pages of book:");
            int page = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter title of a book :");
            string title = Console.ReadLine();

            Console.WriteLine(BookServices.CreateNewBook(id,title,page,author));
        }

        public static Book GetBook()
        {
            Console.WriteLine("Enter book id:");
            int id = int.Parse(Console.ReadLine());
            Book book = BookServices.FindBook(id);
            return book;
        }

        public static void EditBookDetails()
        {
            Book book = GetBook();
            if (book == null)
            {
                Console.WriteLine("Book Id invalid!");
                return;
            }
            Console.WriteLine("Enter title of a book:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter pages of a book:");
            int page = int.Parse(Console.ReadLine());

            Console.WriteLine(BookServices.EditBook(book,title,page));
        }

        public static void DisplayAllBooks()
        {
            Console.WriteLine(BookServices.DisplayAllBooksDetail());
        }

        public static void DeleteBook()
        {
            Book book = GetBook();
            if (book == null)
            {
                Console.WriteLine("Book Id invalid!");
                return;
            }
            Console.WriteLine(BookServices.DeleteBookDetails(book));
        }

        public static void DisplayBookDetail()
        {
            Book book = GetBook();
            if (book == null)
            {
                Console.WriteLine("Book Id invalid!");
                return;
            }
            Console.WriteLine(book.ToString());
        }
    }
}

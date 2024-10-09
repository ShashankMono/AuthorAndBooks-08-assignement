using AuthorsAndBooks.Models;
using AuthorsAndBooks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Presentation
{
    internal class AuthorMenu
    {
        public static void DisplayAuthorMenu()
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome to Author management!\n" +
                    $"1.Create new Author\n" +
                    $"2.Edit an Author details\n" +
                    $"3.Display all authors detail\n" +
                    $"4.Delete an author\n" +
                    $"5.Display an Author details\n" +
                    $"6.Show ALl book of Author\n" +
                    $"7.Exit to main menu\n");

                int choice = int.Parse( Console.ReadLine() );
                ExceuteAuthorMenu(choice);
            }
        }

        public static void ExceuteAuthorMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    TakeDetailsOfAuthor();
                    break;

                case 2:
                    EditAuthorDetails();
                    break;

                case 3:
                    DisplayAllAuthor();
                    break;

                case 4:
                    DeleteAuthor();
                    break;

                case 5:
                    DisplayAuthorDetail();
                    break;

                case 6:
                    DisplayAllBookOfAuthor();
                    break;

                case 7:
                    MainMenu.DisplayMainMenu();
                    break;

                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }

        public static void TakeDetailsOfAuthor()
        {
            Console.WriteLine("Enter Id of an author:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of an author:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email of an author:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Age of an author:");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine(AuthorServices.CreateNewAuthor(id, name, email, age));
        }

        public static Author GetAuthor()
        {
            Console.WriteLine("Enter author id:");
            int id = int.Parse(Console.ReadLine());
            Author author = AuthorServices.FindAuthor(id);
            return author;
        }

        public static void EditAuthorDetails()
        {
            Author author = GetAuthor();
            if (author == null)
            {
                Console.WriteLine("Author Id invalid!");
                return;
            }
            Console.WriteLine("Enter Name of an author:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email of an author:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Age of an author:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(AuthorServices.EditAuthor(author,name,email,age));
        }

        public static void DisplayAllAuthor()
        {
            Console.WriteLine(AuthorServices.DisplayAllAuthorsDetail());
        }

        public static void DeleteAuthor() { 
            Author author = GetAuthor();
            if (author == null)
            {
                Console.WriteLine("Author Id invalid!");
                return;
            }
            Console.WriteLine(AuthorServices.DeleteAuthorDetails(author));
        }

        public static void DisplayAuthorDetail()
        {
            Author author = GetAuthor();
            if (author == null)
            {
                Console.WriteLine("Author Id invalid!");
                return;
            }
            Console.WriteLine(author.ToString());
        }

        public static void DisplayAllBookOfAuthor()
        {
            Author author = GetAuthor();
            if (author == null)
            {
                Console.WriteLine("Author Id invalid!");
                return;
            }
            Console.WriteLine(AuthorServices.ShowBooksDetailsOfAuthor(author));
        }
    }
}

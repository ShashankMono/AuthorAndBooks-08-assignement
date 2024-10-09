using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Presentation
{
    internal class MainMenu
    {
        public static void DisplayMainMenu()
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome to main menu!\n" +
                    $"1.Author management\n" +
                    $"2.Book management\n" +
                    $"3.Exit\n");

                int choice = int.Parse( Console.ReadLine() );
                ExecuteMainMenu( choice );
            }
        }

        public static void ExecuteMainMenu(int choice) {
            switch (choice)
            {
                case 1:
                    AuthorMenu.DisplayAuthorMenu();
                    break;

                case 2:
                    BookMenu.DisplayBookMenu();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}

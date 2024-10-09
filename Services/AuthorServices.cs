using AuthorsAndBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Services
{
    internal class AuthorServices
    {
        public static List<Author> Authors = new List<Author>();
        public static string CreateNewAuthor(int id,string name,string email,int age)
        {
            Author author = new Author(id,name,email,age);
            Authors.Add(author);
            return "Author Added sucessfully!";
        }

        public static Author FindAuthor(int id)
        {
            return Authors.Where(author => author.Id == id).FirstOrDefault();
        }

        public static string EditAuthor(Author author,string name,string email,int age)
        {
            author.Age = age;
            author.Name = name;
            author.Email = email;

            return $"Author with id {author.Id} details updated";

        }

        public static string DisplayAllAuthorsDetail()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Author author in Authors)
            {
                sb.Append(author.ToString() + "\n");
            }
            return sb.ToString();
        }

        public static string DeleteAuthorDetails(Author author)
        {
            Authors.Remove(author);
            return "Deleted sucessfully!";
        }

        public static string ShowBooksDetailsOfAuthor(Author author)
        {
            if(author.Books.Count == 0)
            {
                return "No book present!";
            }
            StringBuilder sb = new StringBuilder();
            foreach (Book book in author.Books) {
                sb.Append(book.ToString()+"\n");
            }
            return sb.ToString();   
        }

        //Not using this function
        //public static string DisplayAuthorDetails(Author author)
        //{
        //    return author.ToString();
        //}
    }
}

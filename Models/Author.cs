using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }  
        public List<Book> Books { get; set; }  = new List<Book>();

        public Author(int id, string name, string email,int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
        }

        public override string ToString()
        {
            return $"=============================\n" +
                $"Id : {Id}\n" +
                $"Name : {Name}\n" +
                $"Email : {Email}\n" +
                $"Age : {Age}\n";
        }
    }
}

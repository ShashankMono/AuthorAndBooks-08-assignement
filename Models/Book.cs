using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages {  get; set; }
        public DateTime PublishingDate { get; set; }
        public Author Author { get; set; }

        public Book(int id, string title,int pages,DateTime date,Author author) { 
            Id = id;
            Title = title;
            Pages = pages;
            PublishingDate = date;
            Author = author;
        }

        public override string ToString()
        {
            return $"===========================\n" +
                $"Id : {Id}\n" +
                $"Title : {Title}\n" +
                $"Pages : {Pages}\n" +
                $"Published on : {PublishingDate}\n" +
                $"Author : {Author.Name}";
        }
    }
}

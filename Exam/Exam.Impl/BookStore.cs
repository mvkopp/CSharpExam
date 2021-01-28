using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Impl
{
    public class BookStore
    {
        private readonly List<Book> books = new List<Book>
        {
            new Book
            {
                Title = "Ta 2ème vie commence quand tu comprends que tu n'en as qu'une",
                Author = "Raphaëlle Giordano",
                Editor = "Pocket",
                PageCount = 256,
                ReleaseDate = new DateTime(2017, 06, 01)
            },
            new Book
            {
                Title = "Le premier jour du reste de ma vie",
                Author = "Virginie Grimaldi",
                Editor = "Le livre de poche",
                PageCount = 162,
                ReleaseDate = new DateTime(2016, 05, 04)
            },
            new Book
            {
                Title = "Chère mamie",
                Author = "Virginie Grimaldi",
                Editor = "Le livre de poche",
                PageCount = 142,
                ReleaseDate = new DateTime(2018, 10, 31)
            },
            new Book
            {
                Title = "Le jour où j'ai appris à vivre",
                Author = "Laurent Gounelle",
                Editor = "Pocket",
                PageCount = 288,
                ReleaseDate = new DateTime(2016, 04, 07)
            },
            new Book
            {
                Title = "Rompre",
                Author = "Yann Moix",
                Editor = "Grasset",
                PageCount = 128,
                ReleaseDate = new DateTime(2019, 01, 02)
            }
        };

        public IEnumerable<Book> GetAllBooks()
        {
            var filter = from book in books
                         select book;
            return filter;
        }

        public IEnumerable<Book> GetAllBooksByDate()
        {
            var filter = from book in books
                         orderby book.ReleaseDate descending
                         select book;
            return filter;
        }

        public IEnumerable<Book> GetAllBooksWrittenByAuthorLastName(string authorLastName)
        {
            var filter = from book in books
                         where book.Author.Split(' ')[1].Equals(authorLastName)
                         select book;
            return filter;
        }

        public IEnumerable<Book> GetAllBooksWrittenByAuthorLastNameAfterYear(string authorLastName)
        {
            var filter = from book in books
                         where book.Author.Split(' ')[1].Equals(authorLastName) && book.ReleaseDate > new DateTime(2017, 01, 01)
                         select book;
            return filter;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PageCount { get; set; }
    }
}

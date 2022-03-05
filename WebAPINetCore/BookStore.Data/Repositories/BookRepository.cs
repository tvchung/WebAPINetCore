using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book{Id=1,Title = "Book 1",Author="John 1",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=2,Title = "Book 2",Author="John 2",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=3,Title = "Book 3",Author="John 3",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=4,Title = "Book 4",Author="John 4",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=5,Title = "Book 5",Author="John 5",Year=2021,CallNumber="0978611889"}
        //};
        private BookStoreContext db = new BookStoreContext();
        public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }

        public Book GetBook(string id)
        {
            return db.Books.FirstOrDefault(x => x.BookId == id);
        }
    }
}

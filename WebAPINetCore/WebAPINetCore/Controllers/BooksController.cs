using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPINetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book{Id=1,Title = "Book 1",Author="John 1",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=2,Title = "Book 2",Author="John 2",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=3,Title = "Book 3",Author="John 3",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=4,Title = "Book 4",Author="John 4",Year=2021,CallNumber="0978611889"},
        //    new Book{Id=5,Title = "Book 5",Author="John 5",Year=2021,CallNumber="0978611889"}
        //};
        private BookRepository books = new BookRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(string id)
        {
            //var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}

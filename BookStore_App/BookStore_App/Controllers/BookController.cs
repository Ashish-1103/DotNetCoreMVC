using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_App.Repository;
using BookStore_App.Models;

namespace BookStore_App.Controllers
{
   
    public class BookController : Controller

    {
        public BookRepository _bookRep = null;
        public BookController()
        {
            _bookRep = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data= _bookRep.GetAllBooks();
            return View();
        }

        public BookModel GetBookById(int id)
        {
            return _bookRep.GetBookById(id);
            
            //return $"Books is = {id}";
        }

        public List<BookModel> SearchBook(string bookname,string author)
        {
            return _bookRep.SearchBook(bookname,author);
        }
    }
}

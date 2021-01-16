using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_App.Models;

namespace BookStore_App.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSourseBook();

        }
        public BookModel GetBookById(int id)
        {
            return DataSourseBook().Where(x => x.id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title,string author)
        {

            return DataSourseBook().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSourseBook()
        {

            return new List<BookModel> {

                new BookModel { id = 101, Author = "Ashish", Title = "MVC" },
                new BookModel { id = 102, Author = "Shilpi", Title = "MVC Core" },
                new BookModel { id = 103, Author = "Ansh", Title = "Web Api" }

                }; 


        }

    }
}

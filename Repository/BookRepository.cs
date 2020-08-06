using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMvcCore.Models;
namespace TestMvcCore.Repository
{
    public class BookRepository : IBookRepository

    {
        public List<BookModel> GetAllBooks()
        {
            return BookDataSource();


        }
        public BookModel GetBooks(int id)
        {
            return  BookDataSource().Where(x => x.Id == id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string searchtext)
        {
            return BookDataSource().FindAll(x => x.Title.Contains(searchtext) || x.Author.Contains(searchtext) || x.Details.Contains(searchtext));
        }

        private List<BookModel> BookDataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id= 1,Title="Mvc1", Author="Auth1" , Details="Mvc1 Details"},
                new BookModel(){Id= 2,Title="Mvc2", Author="Auth2" , Details="Mvc2 Details"},
                new BookModel(){Id= 3,Title="Mvc3", Author="Auth3" , Details="Mvc3 Details"},
                new BookModel(){Id= 4,Title="Mvc4", Author="Auth4" , Details="Mvc4 Details"},
                new BookModel(){Id= 5,Title="Mvc5", Author="Auth5" , Details="Mvc5 Details"},
                new BookModel(){Id= 6,Title="Mvc6", Author="Auth6" , Details="Mvc6 Details"},
                new BookModel(){Id= 7,Title="Mvc7", Author="Auth7" , Details="Mvc7 Details"},
                new BookModel(){Id= 8,Title="Mvc8", Author="Auth8" , Details="Mvc8 Details"},
                new BookModel(){Id= 9,Title="Mvc9", Author="Auth9" , Details="Mvc9 Details"},
            };

        }
    }
}

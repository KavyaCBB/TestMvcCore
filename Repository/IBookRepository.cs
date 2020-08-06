using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestMvcCore.Models;

namespace TestMvcCore.Repository
{
    public interface IBookRepository
    {
        List<BookModel> GetAllBooks();
        BookModel GetBooks(int id);
        List<BookModel> SearchBook(string searchtext);
       
    }
}
    
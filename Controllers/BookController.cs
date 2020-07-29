using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMvcCore.Models;
using TestMvcCore.Repository;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMvcCore.Controllers
{
    public class BookController : Controller
    {
       private readonly IBookRepository _bookRepo;
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public BookController(IBookRepository bookrepos)
        {
            _bookRepo = bookrepos;

        }

        public ViewResult GetAllBooks()
        {
            var bookData = _bookRepo.GetAllBooks();

            ViewData["bookData"] = bookData;
            return View(bookData);
        }

        public BookModel GetBook(int id)
        {
            return _bookRepo.GetBooks(id);
        }
        
    }
}

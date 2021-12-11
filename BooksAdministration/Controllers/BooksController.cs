using BooksAdministration.Data;
using BooksAdministration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BooksAdministration.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> BookList = _context.Book;
            return View(BookList);
        }
        
        // HTTP GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        
    }
}

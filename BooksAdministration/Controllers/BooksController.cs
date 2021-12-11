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

        // GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Book.Add(book);
                _context.SaveChanges();
                TempData["message"] = "Book has been added successfully!";

                return RedirectToAction("Index");
            }
            TempData["message"] = "An error occurred while trying to add the book";

            return View();
        }

        // GET
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var book = _context.Book.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Book.Update(book);
                _context.SaveChanges();
                TempData["message"] = "Successfully updated book!";

                return RedirectToAction("Index");
            }
            TempData["message"] = "An error occurred while trying to edit the book";

            return View();
        }

        // GET
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var book = _context.Book.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int? id)
        {
            var book = _context.Book.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Book.Remove(book);
            _context.SaveChanges();

            TempData["message"] = "Book has been removed successfully!";
            return RedirectToAction("Index");
        }
    }
}

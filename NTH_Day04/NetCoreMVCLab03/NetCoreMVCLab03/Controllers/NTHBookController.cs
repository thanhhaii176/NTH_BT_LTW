using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Controllers
{
    public class NTHBookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors; //TRuyen du lieu SelectListItem qua view
            ViewBag.genres = book.Genres; //Truyen du lieu SelectListItem qua view
            var books = book.GetBookList();
            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = book.GetBookById(id);
            return View(model);
        }

        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}

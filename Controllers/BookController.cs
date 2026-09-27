using Microsoft.AspNetCore.Mvc;
using BaiTapBuoi4.Models;

namespace BaiTapBuoi4.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Name = "Clean Code", Price = 20 },
                new Book { Id = 2, Name = "ASP.NET MVC", Price = 15 },
                new Book { Id = 3, Name = "Design Pattern", Price = 25 }
            };

            return View(books);
        }

        public IActionResult Detail(int id)
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Name = "Clean Code", Price = 20 },
                new Book { Id = 2, Name = "ASP.NET MVC", Price = 15 },
                new Book { Id = 3, Name = "Design Pattern", Price = 25 }
            };

            var book = books.FirstOrDefault(x => x.Id == id);

            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            return Content("Thêm sách thành công");
        }
    }
}
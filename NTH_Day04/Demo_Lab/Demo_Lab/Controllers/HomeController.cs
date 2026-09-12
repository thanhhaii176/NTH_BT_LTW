using Demo_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Lab.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-1),
                IsHot = true
            },

            new Product
            {
                Id = 2,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-2),
                IsHot = true
            },

            new Product
            {
                Id = 3,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-3),
                IsHot = true
            },

            new Product
            {
                Id = 4,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-4),
                IsHot = true
            },

            new Product
            {
                Id = 5,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-5),
                IsHot = true
            },

            new Product
            {
                Id = 6,
                Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                Price = 2350000,
                Image = "/images/comdien.jfif",
                CreatedDate = DateTime.Now.AddDays(-6),
                IsHot = true
            }
        };
        public IActionResult Index()
        {
            var newestProducts = products.OrderByDescending(x => x.CreatedDate).Take(3).ToList();
            return View(newestProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAppMVC.Models;

namespace MyAppMVC.Controllers
{
    public class ProductController : Controller
    {
        //[Route("San pham", Name = "product")]
        public IActionResult Index()
        {
            List<Product> products = GetProducts();
            List<Category> categories = GetCategories();

            ViewBag.Products = products;
            ViewBag.Categories = categories;
            
            return View();
        }

        private List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Quan ao" },
                new Category { Id = 2, Name = "Do boi" },
                new Category { Id = 3, Name = "Do ngu" },
                new Category { Id = 4, Name = "Giay dep" },
                new Category { Id = 5, Name = "Tui xach" },
                new Category { Id = 6, Name = "My pham" },
                new Category { Id = 7, Name = "Do choi" }
            };
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bo do boi cho tre em nam",
                    Image = Url.Content("~/images/Product/01.jpg"),
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Bo do boi danh cho tre em nam.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 2,
                    Name = "Bo do boi cho tre em nu",
                    Image = Url.Content("~/images/Product/02.jpg"),
                    Price = 50000,
                    SalePrice = 35000,
                    CategoryId = 2,
                    Description = "Bo do boi danh cho tre em nu.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 3,
                    Name = "Bo do boi cho tre 3- 5 tuoi",
                    Image = Url.Content("~/images/Product/03.jpg"),
                    Price = 60000,
                    SalePrice = 45000,
                    CategoryId = 2,
                    Description = "Bo do boi danh cho tre 3 den 5 tuoi.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 4,
                    Name = "Bo do boi cho tre em",
                    Image = Url.Content("~/images/Product/04.jpg"),
                    Price = 60000,
                    SalePrice = 45000,
                    CategoryId = 2,
                    Description = "San pham do boi tre em.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 5,
                    Name = "Tui thoi trang mau do",
                    Image = Url.Content("~/images/Product/05.jpg"),
                    Price = 190000,
                    SalePrice = 150000,
                    CategoryId = 5,
                    Description = "Tui thoi trang danh cho nu.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 6,
                    Name = "Tui thoi trang da ca",
                    Image = Url.Content("~/images/Product/06.jpg"),
                    Price = 170000,
                    SalePrice = 130000,
                    CategoryId = 5,
                    Description = "Tui thoi trang bang da.",
                    Status = 1,
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                }
            };
        }

        //[Route("San-pham/sanh-muc/{categoryId}", Name = "product_category")]
        public IActionResult Category(int categoryId)
        {
            List<Product> products = GetProducts();
            List<Category> categories = GetCategories();

            products = products.Where(p => p.CategoryId == categoryId).ToList();

            ViewBag.Products = products;
            ViewBag.Categories = categories;

            return View("Index");
        }

        //[Route("Chi-tiet-san-pham/{id}", Name = "product_detail")]
        public IActionResult Detail(int id)
        {
            List<Product> products = GetProducts();
            Product? product = products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }

            ViewBag.Product = product;
            return View();
        }
    }
}

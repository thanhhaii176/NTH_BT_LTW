using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB05.Models;
using System.ComponentModel;

namespace NetCoreMVCLAB05.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new();
        // GET: ProductController
        public IActionResult Index()
        {
            return View(products);
        }

        // GET: ProductController/Details/5
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        public IActionResult Create()
        {
            ViewBag.Categories = CategoryController.GetCategories();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, IFormFile? imageFile)
        {
            var categories = CategoryController.GetCategories();
            if (!categories.Any(x => x.Id == product.CategoryId))
            {
                ModelState.AddModelError(nameof(Product.CategoryId), "Vui lòng chọn danh mục.");
            }
            if (product.SalePrice >= product.Price * 0.9f)
            {
                ModelState.AddModelError(nameof(Product.SalePrice), "Giá khuyến mãi phải nhỏ hơn 90% giá chuẩn.");
            }
            if (imageFile == null || imageFile.Length == 0)
            {
                ModelState.AddModelError(nameof(Product.Image), "Vui lòng chọn hình ảnh.");
            }
            else
            {
                string extension = Path.GetExtension(imageFile.FileName).ToLower();

                string[] allowedExtensions = {".jpg", ".jpeg", ".png", ".gif", ".jfif"};

                if (!allowedExtensions.Contains(extension))
                {
                    ModelState.AddModelError(nameof(Product.Image), "File ảnh phải là JPG, JPEG, PNG, GIF hoặc JFIF.");
                }
            }
            if (ContainsSensitiveWord(product.Description))
            {
                ModelState.AddModelError(nameof(Product.Description), "Mô tả không được chứa các từ nhạy cảm.");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = categories;
                return View(product);
            }
            product.Id = products.Count == 0 ? 1 : products.Max(x => x.Id) + 1;
            product.Image = await UploadImage(imageFile!);
            products.Add(product);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.Categories = CategoryController.GetCategories();
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product, IFormFile? imageFile)
        {
            if (id != product.Id)
            {
                return NotFound();
            }
            var oldProduct = products.FirstOrDefault(x => x.Id == id);
            if (oldProduct == null)
            {
                return NotFound();
            }
            var categories = CategoryController.GetCategories();
            if (!categories.Any(x => x.Id == product.CategoryId))
            {
                ModelState.AddModelError(nameof(Product.CategoryId), "Vui lòng chọn danh mục.");
            }
            if (product.SalePrice >= product.Price * 0.9f)
            {
                ModelState.AddModelError(nameof(Product.SalePrice), "Giá khuyến mãi phải nhỏ hơn 90% giá chuẩn.");
            }
            if (ContainsSensitiveWord(product.Description))
            {
                ModelState.AddModelError(nameof(Product.Description), "Mô tả không được chứa các từ nhạy cảm.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = categories;
                return View(product);
            }
            oldProduct.Name = product.Name;
            oldProduct.Price = product.Price;
            oldProduct.SalePrice = product.SalePrice;
            oldProduct.Description = product.Description;
            oldProduct.CategoryId = product.CategoryId;
            if (imageFile != null && imageFile.Length > 0)
            {
                DeleteImage(oldProduct.Image);
                oldProduct.Image = await UploadImage(imageFile);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                DeleteImage(product.Image);
                products.Remove(product);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ContainsSensitiveWord(string description)
        {
            string[] sensitiveWords = { "die", "admin", "fack" };
            foreach (var word in sensitiveWords)
            {
                if (description.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private async Task<string> UploadImage(IFormFile imageFile)
        {
            string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "products");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string extension = Path.GetExtension(imageFile.FileName).ToLower();
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".jfif" };
            if (!allowedExtensions.Contains(extension))
            {
                throw new Exception("File ảnh không đúng định dạng.");
            }
            string fileName = Path.GetFileName(imageFile.FileName);
            string filePath = Path.Combine(folder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            return fileName;
        }
        private void DeleteImage(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                return;
            }
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "products", imageName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }

    }
}

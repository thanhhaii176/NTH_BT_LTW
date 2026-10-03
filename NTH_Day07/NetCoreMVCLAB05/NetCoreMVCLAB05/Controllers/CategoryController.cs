using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB05.Models;

namespace NetCoreMVCLAB05.Controllers
{
    public class CategoryController : Controller
    {
        private static readonly List<Category> categories = new();
        // GET: CategoryController
        public IActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public IActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Id = categories.Count == 0 ? 1 : categories.Max(x => x.Id) + 1;
                categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController/Edit/5
        public IActionResult Edit(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id==id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Category category)
        {
            if(id != category.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var oldCategory = categories.FirstOrDefault(x => x.Id == id);
                if(oldCategory == null)
                {
                    return NotFound();
                }
                oldCategory.Name = category.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController/Delete/5
        public IActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = categories.FirstOrDefault(x => x.Id == id);
            if(category != null)
            {
                categories.Remove(category);
            }
            return RedirectToAction(nameof(Index));
        }
        public static List<Category> GetCategories()
        {
            return categories;
        }
    }
}

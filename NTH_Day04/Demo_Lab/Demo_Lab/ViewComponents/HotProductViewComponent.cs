using Demo_Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Lab.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 4,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2350000,
                    Image="/images/comdien.jfif",
                    IsHot = true
                },

                new Product
                {
                    Id = 5,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2350000,
                    Image="/images/comdien.jfif",
                    IsHot = true
                },

                new Product
                {
                    Id = 6,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2350000,
                    Image="/images/comdien.jfif",
                    IsHot = true
                }
            };
            return View(products);
        }
    }
}

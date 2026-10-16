
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lesson08DB_First.Models;

namespace Lesson08DB_First.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly BookStoreDbContext _context;

        public OrderDetailsController(BookStoreDbContext context)
        {
            _context = context;
        }

        // GET: ORDERDETAILS
        public async Task<IActionResult> Index()
        {
            var orderDetails = await _context.OrderDetails
                .Include(o => o.Book)
                .Include(o => o.Order)
                .ToListAsync();
            return View(orderDetails);
        }

        // GET: ORDERDETAILS/Details/5
        public async Task<IActionResult> Details(int? orderdetailid)
        {
            if (orderdetailid == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrderDetails.Include(o => o.Book)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderDetailId == orderdetailid);
            if (orderdetail == null)
            {
                return NotFound();
            }

            return View(orderdetail);
        }

        // GET: ORDERDETAILS/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Orders = await _context.OrderBooks.ToListAsync();
            ViewBag.Books = await _context.Books.ToListAsync();
            return View();
        }

        // POST: ORDERDETAILS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderDetail orderdetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderdetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Orders = await _context.OrderBooks.ToListAsync();
            ViewBag.Books = await _context.Books.ToListAsync();
            return View(orderdetail);
        }

        // GET: ORDERDETAILS/Edit/5
        public async Task<IActionResult> Edit(int? orderdetailid)
        {
            if (orderdetailid == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrderDetails.FindAsync(orderdetailid);
            if (orderdetail == null)
            {
                return NotFound();
            }
            ViewBag.Orders = await _context.OrderBooks.ToListAsync();
            ViewBag.Books = await _context.Books.ToListAsync();
            return View(orderdetail);
        }

        // POST: ORDERDETAILS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? orderdetailid, OrderDetail orderdetail)
        {
            if (orderdetailid != orderdetail.OrderDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderdetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailExists(orderdetail.OrderDetailId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Orders = await _context.OrderBooks.ToListAsync();
            ViewBag.Books = await _context.Books.ToListAsync();
            return View(orderdetail);
        }

        // GET: ORDERDETAILS/Delete/5
        public async Task<IActionResult> Delete(int? orderdetailid)
        {
            if (orderdetailid == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrderDetails.Include(o => o.Book).Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderDetailId == orderdetailid);
            if (orderdetail == null)
            {
                return NotFound();
            }

            return View(orderdetail);
        }

        // POST: ORDERDETAILS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? orderdetailid)
        {
            var orderdetail = await _context.OrderDetails.FindAsync(orderdetailid);
            if (orderdetail != null)
            {
                _context.OrderDetails.Remove(orderdetail);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailExists(int? orderdetailid)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailId == orderdetailid);
        }
    }

}

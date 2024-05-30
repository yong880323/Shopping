using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ShoporderController : Controller
    {
        private readonly ShopDbController _context;

        public ShoporderController(ShopDbController context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Shoporders = await _context.Shoporders.ToListAsync();
            return View(Shoporders);
        }

        [HttpPost]
        public async Task<IActionResult> Confirm(List<int> selectedOrders)
        {
            foreach (var orderId in selectedOrders)
            {
                var ordersToUpdate = await _context.Shoporders
                    .Where(o => selectedOrders.Contains(o.Id))
                    .ToListAsync();  // 一次獲取所有訂單
                var order = await _context.Shoporders.FindAsync(orderId);
                foreach (var Shoporder in ordersToUpdate)
                {
                    Shoporder.Status = 2;
                }
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

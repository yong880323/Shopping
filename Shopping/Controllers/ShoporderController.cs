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
            var shoporderList = await _context.Shoporder.ToListAsync();

            var statusToContMap = await _context.Param
                .Where(p => _context.Shoporder.Select(so => so.Status).Contains(p.Tag))
                .ToDictionaryAsync(p => p.Tag, p => p.CONT);

            // 直接將資料傳遞給視圖
            ViewBag.ShoporderList = shoporderList;
            ViewBag.StatusToContMap = statusToContMap;

            return View(); // 不需要傳遞模型

        }

        [HttpPost]
        public async Task<IActionResult> Confirm(List<int> selectedOrders)
        {
            foreach (var orderId in selectedOrders)
            {
                var ordersToUpdate = await _context.Shoporder
                    .Where(o => selectedOrders.Contains(o.Id))
                    .ToListAsync();  // 一次獲取所有訂單
                var order = await _context.Shoporder.FindAsync(orderId);
                foreach (var Shoporder in ordersToUpdate)
                {
                    Shoporder.Status = 2;
                }
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        public IActionResult Details(int Id)
        {
            var order = _context.Shoporder.FirstOrDefault(o => o.Id == Id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }
}

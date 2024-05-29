using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Shopping.Data
{
    public class ShopDbController : DbContext
    {
        public ShopDbController(DbContextOptions<ShopDbController> options) : base(options) { }
    }
}

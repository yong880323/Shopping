using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Data
{
    public class ShopDbController : DbContext
    {
        public ShopDbController(DbContextOptions<ShopDbController> options) : base(options) { }

        public DbSet<Shoporder> Shoporders {  get; set; }

        /// <summary>
        /// 新增測試資料
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shoporder>().HasData(
                new Shoporder { Id = 1, UserId = 1, OrderId = "A20202026001", OrderItem = "Product1", Price = 100, Cost = 90, Status = 1 },
                new Shoporder { Id = 2, UserId = 1, OrderId = "A20202023001", OrderItem = "Product2", Price = 120, Cost = 100, Status = 1 },
                new Shoporder { Id = 3, UserId = 1, OrderId = "A20202026002", OrderItem = "Product3", Price = 200, Cost = 150, Status = 1 },
                new Shoporder { Id = 4, UserId = 1, OrderId = "A20202024003", OrderItem = "Product4", Price = 150, Cost = 120, Status = 1 }
                );
        }
    }
}

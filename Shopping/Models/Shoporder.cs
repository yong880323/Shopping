namespace Shopping.Models
{
    public class Shoporder
    {
        /// <summary>
        /// 流水碼
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 使用者編號
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 訂單編號
        /// </summary>
        public string OrderId { get; set; } = null!;

        /// <summary>
        /// 訂單名稱
        /// </summary>
        public string OrderItem { get; set; } = null!;

        /// <summary>
        /// 金額
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// 狀態
        /// </summary>
        public int Status { get; set; }
    }
}

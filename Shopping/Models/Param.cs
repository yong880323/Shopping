namespace Shopping.Models
{
    public class Param
    {
        /// <summary>
        /// 流水碼
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 參數碼
        /// </summary>
        public int Tag { get; set; }

        /// <summary>
        /// 流水碼
        /// </summary>
        public int Seq_no { get; set; }
        /// <summary>
        /// 參數值
        /// </summary>
        public string CONT { get; set; } = null!;
    }
}

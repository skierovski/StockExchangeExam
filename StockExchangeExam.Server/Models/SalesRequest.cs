namespace StockExchangeExam.Server.Models
{
    public class SalesRequest
    {
        public int SharesToSell { get; set; }
        public decimal SellingPricePerShare { get; set; }
    }
}

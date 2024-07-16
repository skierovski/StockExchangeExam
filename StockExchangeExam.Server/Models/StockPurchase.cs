namespace StockExchangeExam.Server.Models
{
    public class StockPurchase
    {
        public int Id { get; set; }
        public int Shares { get; set; }
        public decimal PricePerShare { get; set; }

        public StockPurchase(int id, int shares, decimal pricePerShare)
        {
            Id = id;
            Shares = shares;
            PricePerShare = pricePerShare;
        }
    }
}

namespace StockExchangeExam.Server.Models
{
    public class StockPurchase
    {
        private int _shares;
        private decimal _pricePerShare;

        public int Id { get; set; }

        public int Shares
        {
            get => _shares;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Shares cannot be negative.");
                _shares = value;
            }
        }

        public decimal PricePerShare
        {
            get => _pricePerShare;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price per share cannot be negative.");
                _pricePerShare = value;
            }
        }

        public DateTime PurchaseDate { get; set; }

    }
}

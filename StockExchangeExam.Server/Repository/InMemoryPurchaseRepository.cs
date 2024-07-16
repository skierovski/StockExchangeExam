using StockExchangeExam.Server.Models;

namespace StockExchangeExam.Server.Repository
{
    public class InMemoryPurchaseRepository: IStockPurchaseRepository
    {
        private readonly List<StockPurchase> _stockPurchases;

        public InMemoryPurchaseRepository()
        {
            // Here you can change values of purchased stocks 
            _stockPurchases = new List<StockPurchase>
            {
                new StockPurchase { Shares = 100, PricePerShare = 20, PurchaseDate = new DateTime(2023, 1, 1) },
                new StockPurchase { Shares = 150, PricePerShare = 25, PurchaseDate = new DateTime(2023, 2, 1) },
                new StockPurchase { Shares = 120, PricePerShare = 22, PurchaseDate = new DateTime(2023, 3, 1) }
            };
        }

        public List<StockPurchase> GetAll()
        {
            return _stockPurchases;
        }
    }
}

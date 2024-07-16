using StockExchangeExam.Server.Models;

namespace StockExchangeExam.Server.Services
{
    public class LifoCostAccountingService : ICostAccountingService
    {
        public decimal CalculateProfit(List<StockPurchase> stockPurchases, int sharesToSell, decimal sellingPricePerShare)
        {
           // TODO: Implement the LIFO cost accounting method
            throw new NotImplementedException("Later Implementation");
        }
    }
}

using StockExchangeExam.Server.Models;

namespace StockExchangeExam.Server.Services
{
    public interface ICostAccountingService
    {
        decimal CalculateProfit(List<StockPurchase> stockPurchases ,int sharesToSell, decimal sellingPricePerShare);
    }
}

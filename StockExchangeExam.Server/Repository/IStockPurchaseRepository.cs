using StockExchangeExam.Server.Models;

namespace StockExchangeExam.Server.Repository
{
    public interface IStockPurchaseRepository
    {
        List<StockPurchase> GetAll();
    }
}

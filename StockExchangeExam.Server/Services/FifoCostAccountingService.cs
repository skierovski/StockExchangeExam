using StockExchangeExam.Server.Models;

namespace StockExchangeExam.Server.Services
{
    public class FifoCostAccountingService : ICostAccountingService
    {
        public decimal CalculateProfit(List<StockPurchase> stockPurchases, int sharesToSell, decimal sellingPricePerShare)
        {
            // Validate input to ensure shares to sell and selling price are greater than zero
            if (sharesToSell <= 0 || sellingPricePerShare <= 0)
            {
                throw new ArgumentException("Shares to sell and selling price must be greater than zero.");
            }

            // Sort the stock purchases by purchase date to apply FIFO logic
            stockPurchases = stockPurchases.OrderBy(sp => sp.PurchaseDate).ToList();
            int remainingShares = sharesToSell;
            decimal totalCost = 0;
            int totalSoldShares = 0;

            // Calculate the cost of shares sold and update the remaining shares and total cost
            CalculateCostAndShares(stockPurchases, ref remainingShares, ref totalCost, ref totalSoldShares);

            // Calculate the total revenue from selling the shares
            decimal totalRevenue = CalculateTotalRevenue(totalSoldShares, sellingPricePerShare);

            // Calculate the total profit by subtracting the total cost from the total revenue
            decimal totalProfit = CalculateTotalProfit(totalRevenue, totalCost);

            return totalProfit;
        }

        private void CalculateCostAndShares(List<StockPurchase> stockPurchases, ref int remainingShares,  ref decimal totalCost, ref int totalSoldShares)
        {
            foreach (var lot in stockPurchases)
            {
                if (remainingShares <= 0)
                    break;

                int sharesSoldFromLot = Math.Min(lot.Shares, remainingShares);
                totalCost += sharesSoldFromLot * lot.PricePerShare;
                remainingShares -= sharesSoldFromLot;
                lot.Shares -= sharesSoldFromLot;
                totalSoldShares += sharesSoldFromLot;
            }
        }

        private decimal CalculateTotalRevenue(int totalSharesSold, decimal sellingPricePerShare)
        {
            return totalSharesSold * sellingPricePerShare;
        }

        private decimal CalculateTotalProfit(decimal totalRevenue, decimal totalCost)
        {
            return totalRevenue - totalCost;
        }
    }
}

using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using StockExchangeExam.Server.Models;

namespace StockExchangeTests
{
    [TestClass]
    public class CalcuationsTests
    {
        [TestMethod]
        public void TestCalculateSale()
        {
            // Arrange
            var purchaseLots = new List<StockPurchase>
            {
            new StockPurchase { Shares = 100, PricePerShare = 20, PurchaseDate = new DateTime(2023, 1, 1) },
            new StockPurchase { Shares = 150, PricePerShare = 30, PurchaseDate = new DateTime(2023, 2, 1) },
            new StockPurchase { Shares = 120, PricePerShare = 10, PurchaseDate = new DateTime(2023, 3, 1) }
            };
            int sharesToSell = 200;
            decimal sellingPricePerShare = 40;

            // Act
            var result = 

            // Assert
            Assert.AreEqual(170, result.RemainingShares);
            Assert.AreEqual(25, result.CostBasisSoldShares);
            Assert.AreEqual(20, result.CostBasisRemainingShares); // Adjust expected value based on calculation
            Assert.AreEqual(3000, result.TotalProfit);
        }
    }
}

using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using NUnit.Framework;
using StockExchangeExam.Server.Models;
using StockExchangeExam.Server.Services;
using System;
using System.Collections.Generic;

namespace StocksExchangeTests
{

    public class CalculationTests
    {
        private ICostAccountingService _costAccountingService;


        [SetUp]
        public void SetUp()
        {
            _costAccountingService = new FifoCostAccountingService();
        }

        [Test]
        public void TestCalculateSale()
        {
            var purchaseLots = new List<StockPurchase>
                {
                    new StockPurchase { Shares = 100, PricePerShare = 20, PurchaseDate = new DateTime(2023, 1, 1) },
                    new StockPurchase { Shares = 150, PricePerShare = 30, PurchaseDate = new DateTime(2023, 2, 1) },
                    new StockPurchase { Shares = 120, PricePerShare = 10, PurchaseDate = new DateTime(2023, 3, 1) }
                };
            int sharesToSell = 200;
            decimal sellingPricePerShare = 40;

            var result = _costAccountingService.CalculateProfit(purchaseLots, sharesToSell, sellingPricePerShare);

            Assert.That(result, Is.EqualTo(3000)); 
        }
    }
}

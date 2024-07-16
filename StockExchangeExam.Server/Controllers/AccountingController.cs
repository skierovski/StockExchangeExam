using Microsoft.AspNetCore.Mvc;
using StockExchangeExam.Server.Models;
using StockExchangeExam.Server.Repository;
using StockExchangeExam.Server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockExchangeExam.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : ControllerBase
    {
        private readonly IStockPurchaseRepository _repository;
        private readonly ICostAccountingService _service;
        public AccountingController(IStockPurchaseRepository repository, ICostAccountingService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpPost]
        [Route("calculate")]
        public IActionResult Calculate([FromBody] SalesRequest salesRequest)
        {
            var stockPurchases = _repository.GetAll();
            var profit = _service.CalculateProfit(stockPurchases, salesRequest.SharesToSell, salesRequest.SellingPricePerShare);
            return Ok(profit);
        }
    }
}

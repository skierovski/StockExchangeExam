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
            try
            {
                var stockPurchases = _repository.GetAll();
                var profit = _service.CalculateProfit(stockPurchases, salesRequest.SharesToSell, salesRequest.SellingPricePerShare);
                return Ok(profit);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred while calculating profit. Please try again later." });
            }
        }
    }
}

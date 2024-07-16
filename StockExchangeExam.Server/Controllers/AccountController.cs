using Microsoft.AspNetCore.Mvc;
using StockExchangeExam.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockExchangeExam.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly List<StockPurchase> _stockPurchases;
        public AccountController()
        {
            _stockPurchases = new List<StockPurchase>
            {
                // Here you can change what stock you already purchased i did not create any repository for this because it simpler here to manipulate data
                new StockPurchase(1, 10, 100),
                new StockPurchase(2, 20, 200),
                new StockPurchase(3, 30, 300),
            };
        }

        [HttpPost]
        [Route("calculate")]
        public IActionResult Calculate([FromBody] SalesRequest salesRequest)
        {
               return Ok();
        }
    }
}

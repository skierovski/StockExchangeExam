using Microsoft.AspNetCore.Mvc;
using StockExchangeExam.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockExchangeExam.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
       
        [HttpPost]
        [Route("calculate")]
        public IActionResult Calculate([FromBody] SalesRequest salesRequest)
        {
               return Ok();
        }
    }
}

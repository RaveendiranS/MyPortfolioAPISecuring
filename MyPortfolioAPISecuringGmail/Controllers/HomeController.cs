using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyPortfolioAPISecuringGmail.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("GetGAccessKey")]
        public IActionResult GetGAccessKey([FromQuery] string password)
        {
            if (password == "Muttal")
            {
                return Ok("d0c2aff7-4d1f-40a6-8913-940068b8f703");
            }

            return Unauthorized("Invalid password.");
        }
    }
}

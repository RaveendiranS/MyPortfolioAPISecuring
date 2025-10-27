using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Text;


namespace MyPortfolioAPISecuringGmail.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        [HttpGet("GetGAccessKey")]
        public string getGAccessKey(string password)
        {

            if (password.Equals("Muttal"))
            {
                return "d0c2aff7-4d1f-40a6-8913-940068b8f703";  
            }

            return "Ada loosu paiyale";
        }
    }
}

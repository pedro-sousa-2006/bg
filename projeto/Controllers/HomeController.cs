using Microsoft.AspNetCore.Mvc;

namespace projeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("home")]
        [Route("")]

        public IActionResult Index()
        {
            return View();
        }



 
    }
}

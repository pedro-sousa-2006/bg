using Microsoft.AspNetCore.Mvc;

namespace projeto.Models
{
    public class ErrorViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

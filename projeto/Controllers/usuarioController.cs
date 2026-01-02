using Microsoft.AspNetCore.Mvc;
using projeto.Models;

namespace projeto.Controllers
{
    public class usuarioController : Controller
    {
        [Route("login")]
        
        public IActionResult index(usuarioViewModel model)
        {
            if(model.login == null)
            {
                return View(model);
            }if(model.senha == null)
            {
                return View(model);
            }
            else
            {
                RedirectToAction("Home" , "Index");
            }
                return View();
        }
    }
}

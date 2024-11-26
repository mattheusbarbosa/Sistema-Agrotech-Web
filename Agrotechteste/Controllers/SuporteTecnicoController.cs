using Microsoft.AspNetCore.Mvc;

namespace Agrotechteste.Controllers
{
    public class SuporteTecnicoController : Controller
    {
       
        public IActionResult Index()
        {
            return View("SuporteTecnico");
        }
    }
}
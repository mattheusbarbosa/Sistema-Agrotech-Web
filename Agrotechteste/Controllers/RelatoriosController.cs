using Microsoft.AspNetCore.Mvc;

namespace Agrotechteste.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Relatorios()
        {
            return View();
        }
    }
}

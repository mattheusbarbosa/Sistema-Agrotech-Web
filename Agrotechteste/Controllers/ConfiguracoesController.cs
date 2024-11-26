using Microsoft.AspNetCore.Mvc;

namespace Agrotechteste.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Configuracoes()
        {
            return View();
        }
    }
}

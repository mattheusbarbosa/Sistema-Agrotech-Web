using Microsoft.AspNetCore.Mvc;
using Agrotechteste.Models;

namespace Agrotechteste.Controllers
{
    public class CadastrarFuncionarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastrarFuncionarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("CadastrarFuncionario"); 
        }

       
        [HttpPost]
        public IActionResult CadastrarFuncionario(Usuario funcionario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Usuarios.Add(funcionario);
                    _context.SaveChanges();

                    
                    ModelState.Clear();

                   
                    return RedirectToAction("Index", "Home"); 
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"Erro ao salvar funcionário: {ex.Message}");
                    ModelState.AddModelError("", "Ocorreu um erro ao salvar o funcionário. Tente novamente.");
                }
            }

           
            return View("CadastrarFuncionario", funcionario);
        }
    }
}

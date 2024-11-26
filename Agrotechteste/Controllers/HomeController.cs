using Agrotechteste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; 
using System.Linq;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

   
    public IActionResult Login()
    {
        
        if (HttpContext.Session.GetInt32("UserId") != null)
        {
            return RedirectToAction("Index", "Home"); 
        }
        return View();
    }

    
    public IActionResult Index()
    {
       
        if (HttpContext.Session.GetInt32("UserId") == null)
        {
            return RedirectToAction("Login", "Home"); 
        }
        return View();
    }

   
    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.nome_usuario == model.nome_usuario && u.senha_usuario == model.senha_usuario);

            


            if (usuario != null)
            {
               
                HttpContext.Session.SetInt32("UserId", usuario.idUsuario);

                
                return RedirectToAction("Index", "Home");
            }

            
            ModelState.AddModelError("", "Usuário ou senha inválidos.");
        }

       
        return View(model);
    }

   
    public IActionResult Logout()
    {
        
        HttpContext.Session.Clear();

       
        return RedirectToAction("Login", "Home");
    }
}

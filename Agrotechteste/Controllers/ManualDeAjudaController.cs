using Microsoft.AspNetCore.Mvc;

public class ManualdeAjudaController : Controller
{
    public IActionResult Index()
    {
        // Aqui você pode renderizar a página de ajuda, se necessário
        return View();
    }

    // Ação para baixar o PDF
    public IActionResult BaixarManual()
    {
        var caminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Pdfs", "manual_de_ajuda.pdf");

        if (System.IO.File.Exists(caminhoArquivo))
        {
            var fileBytes = System.IO.File.ReadAllBytes(caminhoArquivo);
            return File(fileBytes, "application/pdf", "manual_de_ajuda.pdf");
        }

        return NotFound();  // Caso o arquivo não exista
    }
}

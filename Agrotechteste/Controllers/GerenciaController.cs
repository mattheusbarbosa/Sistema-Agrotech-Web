using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Agrotechteste.Models;

namespace Agrotechteste.Controllers
{
    public class RelatorioGerenciaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelatorioGerenciaController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Gerencia()
        {
            
            var faturamentoTotal = _context.ItemVendas
                .Sum(iv => iv.valor_Total); 

            
            var despesaTotal = _context.Insumo
                .Sum(insumo => insumo.Valor_Insumo); 

            
            var relatorioGerencia = new List<GerenciaRelatorio>
            {
                new GerenciaRelatorio
                {
                    valor_Total = faturamentoTotal, 
                    Valor_Insumo = despesaTotal,    
                    Liquido = faturamentoTotal - despesaTotal 
                }
            };

            return View(relatorioGerencia); 
        }
    }
}

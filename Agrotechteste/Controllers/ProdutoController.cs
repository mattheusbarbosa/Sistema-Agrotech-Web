using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

using Agrotechteste.Models; 

namespace Agrotechteste.Controllers
{
    public class RelatorioProdutoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelatorioProdutoController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Produto()
        {
        
            var relatorioProdutos = (from produto in _context.Produtos
                                     join lote in _context.Lotes on produto.ID_Produto equals lote.ID_Produto
                                     join item_venda in _context.ItemVendas on produto.ID_Produto equals item_venda.id_Item_Venda
                                     group new { produto, lote, item_venda } by new
                                     {
                                         produto.ID_Produto,
                                         produto.Nome_Produto
                                     } into g
                                     select new ProdutoRelatorio
                                     {
                                         ID_Produto = g.Key.ID_Produto,
                                         Nome_Produto = g.Key.Nome_Produto,
                                         Quantidade = g.Sum(x => x.lote.Quantidade),
                                         quantidade_Saida = g.Sum(x => x.item_venda.quantidade_Saida),
                                         Estoque = g.Sum(x => x.lote.Quantidade) - g.Sum(x => x.item_venda.quantidade_Saida)
                                     }).ToList();

            return View(relatorioProdutos);
        }
    }
}

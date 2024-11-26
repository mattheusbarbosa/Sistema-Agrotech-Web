using Agrotechteste.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Agrotechteste.ViewModels
{
    public class VendasViewModel
    {
        public int id_Venda { get; set; } 

        public int Nm_Venda { get; set; }
        public DateTime data_Venda { get; set; }
        public TimeSpan hora_Venda { get; set; }

        public int idUsuario { get; set; }
        public int idCliente { get; set; } 
        public string pagamento { get; set; }
        public int Qt_Parcela { get; set; } 

        public int ID_Produto { get; set; } 
        public int quantidadeSaida { get; set; } 
        public decimal Valor { get; set; } 
        public decimal desconto { get; set; } 
        public decimal valorSaida { get; set; } 

        
      
        public Usuario Usuario { get; set; }

        
        public SelectList Clientes { get; set; } 
        public SelectList Produtos { get; set; }  
        public SelectList FormasPagamento { get; set; } 
        public List<SelectListItem> Usuarios { get; set; } = new List<SelectListItem>();
    }
}

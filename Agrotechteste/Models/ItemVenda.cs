namespace Agrotechteste.Models
{
    public class item_Venda
    {
        public int id_Item_Venda { get; set; }
        public int id_Venda { get; set; }
        public string tipo_Produto { get; set; }
        public int quantidade_Saida { get; set; }
        public decimal valor_Un { get; set; }
        public decimal desconto { get; set; }
        public decimal valor_Total { get; set; }
    }
}

namespace Agrotechteste.Models
{
    public class Insumo
    {
        public int ID_Insumo { get; set; }
        public string Nome_Produto { get; set; }
        public string Unidade_Medida { get; set; }
        public decimal Valor_Insumo { get; set; }

        // Relacionamento com os lotes
        public ICollection<Lotes_Insumo> Lotes { get; set; } = new List<Lotes_Insumo>();
    }
}

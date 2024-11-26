namespace Agrotechteste.Models
{
    public class Lotes_Insumo
    {
        public int ID_Lote { get; set; }
        public int ID_Insumo{ get; set; }
        public int N_Lote { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public string Intercorrencia_Lote { get; set; }

        public Insumo Insumo { get; set; }
    }
}

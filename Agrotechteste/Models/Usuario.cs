namespace Agrotechteste.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; } // Chave primária
        public string nome { get; set; }
        public string cpf { get; set; } // CPF único
        public string nome_usuario { get; set; }
        public string senha_usuario { get; set; }
    }
}

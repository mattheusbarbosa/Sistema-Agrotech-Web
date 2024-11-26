using System.ComponentModel.DataAnnotations;

namespace Agrotechteste.Models 
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nome de usuário é obrigatório.")]
        public string nome_usuario { get; set; } 

        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string senha_usuario { get; set; } 

       
    }
}

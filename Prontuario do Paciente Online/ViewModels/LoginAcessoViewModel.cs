using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class LoginAcessoViewModel
    {
        [Required(ErrorMessage= "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Lembrar-me")]
        public bool RememberMe { get; set;}
    }
}

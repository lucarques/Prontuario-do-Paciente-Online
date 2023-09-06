using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class CadastroAcessoViewModel
    {
        [Required(ErrorMessage = "O campo de email é obrigatório.")]
        [RegularExpression(@"^.+@.+\..+$", ErrorMessage = "Informe um email válido.")]
        public string? Email { get; set; }

        [Required]
        public string? Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string? ConfirmPassword { get; set;}

        [Required]
        public string? PermissaoNome { get; set; }

    }
}

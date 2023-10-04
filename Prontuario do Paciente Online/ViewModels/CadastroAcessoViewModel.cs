using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class CadastroAcessoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo de email é obrigatório.")]
        [RegularExpression(@"^.+@.+\..+$", ErrorMessage = "Informe um email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "O campo Confirme a senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string? ConfirmPassword { get; set;}

        [Required]
        [Display(Name = "Tipo de Acesso")]
        public string? PermissaoNome { get; set; }

        public MedicoViewModel? Medico { get; set; }

        public EnumStatusAcesso EnumStatusAcesso { get; set; }

    }
}

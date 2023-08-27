using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class UsuarioAcessoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Usuario é obrigatório.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string SenhaAcesso { get; set; }
        public EnumTipoAcesso TipoAcesso { get; set; }
    }
}

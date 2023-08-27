using Prontuario_do_Paciente_Online.Models;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class AcompanhanteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string NomeAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CpfAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        public string EstadoAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string CidadeAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string EnderecoAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        public int NumeroAcompanhante { get; set; }
        [Required(ErrorMessage = "O campo Grau de Parentesco é obrigatório.")]
        public string GrauParentesco { get; set; }
        public UsuarioAcessoViewModel UsuarioAcesso { get; set; }

    }
}

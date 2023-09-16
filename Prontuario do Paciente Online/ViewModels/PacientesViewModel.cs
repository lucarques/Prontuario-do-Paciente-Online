using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class PacientesViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo Endereco é obrigatório.")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo Motivo é obrigatório.")]
        public string MotivoInternacao { get; set; }
        public DateTime DataInternacao { get; set; } = DateTime.UtcNow;
        public string? Cid { get; set; }
        public AcompanhanteViewModel Acompanhante { get; set; }
        public EnumStatus? StatusPaciente { get; set; }
        public CadastroAcessoViewModel CadastroAcesso { get; set; }
    }
}

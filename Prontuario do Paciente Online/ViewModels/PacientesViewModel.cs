using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class PacientesViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string MotivoInternacao { get; set; }
        public AcompanhanteViewModel Acompanhante { get; set; }
        public EnumStatus? StatusPaciente { get; set; }
    }
}

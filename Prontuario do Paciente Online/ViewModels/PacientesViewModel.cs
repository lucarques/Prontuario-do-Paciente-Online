using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class PacientesViewModel
    {
        public int Id { get; set; }
        public Acompanhante Acompanhante { get; set; }
        public Pacientes Paciente { get; set; }
        public List<EnumStatus>? StatusPaciente { get; set; }
    }
}

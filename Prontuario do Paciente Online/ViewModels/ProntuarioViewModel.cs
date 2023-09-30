using Prontuario_do_Paciente_Online.Models.Enums;
using Prontuario_do_Paciente_Online.Models;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class ProntuarioViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Diagnostico { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public int Quarto { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string AvaliacaoMedico { get; set; }
        public DateTime? DataProntuario { get; set; }
        public MedicoViewModel Medico { get; set; }
        public PacientesViewModel Paciente { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public EnumStatus EnumStatus { get; set; }
    }

    public class ProntuarioCreateViewModel
    {
        [Required(ErrorMessage = "O campo Diagnostico é obrigatório.")]
        public string Diagnostico { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Quarto é obrigatório.")]
        public int Quarto { get; set; }

        [Required(ErrorMessage = "O campo AvaliacaoMedico é obrigatório.")]
        public string AvaliacaoMedico { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Médico é obrigatório.")]
        public int MedicoId { get; set; }

        public int PacienteId { get; set; }

        public string PacienteNome { get; set; } = string.Empty;
        
        public DateTime PacienteDataInternacao { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public EnumStatus EnumStatus { get; set; }
    }
}

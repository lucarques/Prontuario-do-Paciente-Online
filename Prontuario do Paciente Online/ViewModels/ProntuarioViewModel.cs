using Prontuario_do_Paciente_Online.Models.Enums;
using Prontuario_do_Paciente_Online.Models;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class ProntuarioViewModel
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public string Quarto { get; set; }
        public string Diagnostico { get; set; }
        public string AvaliacaoMedico { get; set; }
        public DateTime? DataProntuario { get; set; }
        public EnumStatus EnumStatus { get; set; }
    }

    public class ProntuarioCreateViewModel
    {
        public int Id { get; set; }
        public Paciente Paciente {get; set;}
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public string Quarto { get; set; }
        public string Diagnostico { get; set; }
        public string AvaliacaoMedico { get; set; }
        public DateTime DataProntuario { get; set; }= DateTime.UtcNow;
        public EnumStatus EnumStatus { get; set; }

    }
}

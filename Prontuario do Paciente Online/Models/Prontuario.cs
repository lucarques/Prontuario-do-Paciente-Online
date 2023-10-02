using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Quarto { get; set; }
        public string AvaliacaoMedico { get; set; }
        public DateTime DataProntuario { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public EnumStatus EnumStatus { get; set; }

        public Prontuario()
        {
        }

        public Prontuario(int id, string diagnostico, string quarto, string observacao, DateTime dataProntuario, int medicoId, int pacienteId, EnumStatus enumStatus, string avaliacaoMedico)
        {
            Id = id;
            Diagnostico = diagnostico;
            Quarto = quarto;
            AvaliacaoMedico = avaliacaoMedico;
            DataProntuario = dataProntuario;
            MedicoId = medicoId;
            PacienteId = pacienteId;
            EnumStatus = enumStatus;
        }
    }
}

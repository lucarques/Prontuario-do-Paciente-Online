using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public int Quarto { get; set; }
        public string AvaliacaoMedico { get; set; }
        public DateTime DataProntuario { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public EnumStatus EnumStatus { get; set; }

        public Prontuario()
        {
        }

        public Prontuario(int id, string diagnostico, int quarto, string observacao, DateTime dataProntuario, Medico medico, Paciente paciente, EnumStatus enumStatus, string avaliacaoMedico)
        {
            Id = id;
            Diagnostico = diagnostico;
            Quarto = quarto;
            AvaliacaoMedico = avaliacaoMedico;
            DataProntuario = dataProntuario;
            Medico = medico;
            Paciente = paciente;
            EnumStatus = enumStatus;
        }
    }
}

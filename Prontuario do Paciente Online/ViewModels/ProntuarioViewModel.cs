using Prontuario_do_Paciente_Online.Models.Enums;
using Prontuario_do_Paciente_Online.Models;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class ProntuarioViewModel
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public int Quarto { get; set; }
        public string Observacao { get; set; }
        public DateTime DataProntuario { get; set; }
        public Medico Medico { get; set; }
        public EnumStatus EnumStatus { get; set; }
    }
}

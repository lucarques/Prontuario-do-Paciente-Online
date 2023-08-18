using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Pacientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string MotivoInternacao { get; set; }
        public Acompanhante Acompanhante { get; set; }
        public List<EnumStatus>? StatusPaciente { get; set; }

    }
}


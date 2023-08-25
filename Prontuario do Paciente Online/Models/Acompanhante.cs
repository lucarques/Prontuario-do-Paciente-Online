namespace Prontuario_do_Paciente_Online.Models
{
    public class Acompanhante
    {
        public int Id { get; set; }
        public string NomeAcompanhante { get; set; }
        public string CpfAcompanhante { get; set; }
        public string EstadoAcompanhante { get; set; }
        public string CidadeAcompanhante { get; set; }
        public string EnderecoAcompanhante { get; set; }
        public int NumeroAcompanhante { get; set; }
        public string GrauParentesco { get; set; }
        public UsuarioAcesso UsuarioAcesso { get; set; }

        public Acompanhante()
        {
        }

        public Acompanhante(int id, string nomeAcompanhante, string cpfAcompanhante, string estadoAcompanhante, string cidadeAcompanhante, string enderecoAcompanhante, int numeroAcompanhante, string grauParentesco)
        {
            Id = id;
            NomeAcompanhante = nomeAcompanhante;
            CpfAcompanhante = cpfAcompanhante;
            EstadoAcompanhante = estadoAcompanhante;
            CidadeAcompanhante = cidadeAcompanhante;
            EnderecoAcompanhante = enderecoAcompanhante;
            NumeroAcompanhante = numeroAcompanhante;
            GrauParentesco = grauParentesco;
        }
    }
}

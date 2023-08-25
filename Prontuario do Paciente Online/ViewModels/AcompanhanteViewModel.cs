using Prontuario_do_Paciente_Online.Models;

namespace Prontuario_do_Paciente_Online.ViewModels
{
    public class AcompanhanteViewModel
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

    }
}

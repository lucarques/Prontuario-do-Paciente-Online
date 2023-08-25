using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.Models
{
    public class UsuarioAcesso
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string SenhaAcesso { get; set; }
        public EnumTipoAcesso TipoAcesso { get; set; }
    }
}

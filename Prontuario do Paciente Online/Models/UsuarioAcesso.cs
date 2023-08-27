using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.Models
{
    public class UsuarioAcesso
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string SenhaAcesso { get; set; }
        public EnumTipoAcesso TipoAcesso { get; set; }

        public UsuarioAcesso() 
        {

        }
        public UsuarioAcesso(int id, string usuario, string email, string senhaAcesso, EnumTipoAcesso tipoAcesso)
        {
            Id = id;
            Usuario = usuario;
            Email = email;
            SenhaAcesso = senhaAcesso;
            TipoAcesso = tipoAcesso;
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Prontuario_do_Paciente_Online.Models
{
    public class CadastroAcesso
    {
        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string PermissaoNome { get; set; }

        public Medico Medico { get; set; }
        public CadastroAcesso()
        {
        }

        public CadastroAcesso(string email, string usuario, string password, string confirmPassword, string permissaoNome, Medico medico)
        {
            Email = email;
            Usuario = usuario;
            Password = password;
            ConfirmPassword = confirmPassword;
            PermissaoNome = permissaoNome;
            Medico = medico;
        }
    }
}

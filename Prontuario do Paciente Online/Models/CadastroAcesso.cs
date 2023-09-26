using Prontuario_do_Paciente_Online.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Prontuario_do_Paciente_Online.Models
{
    public class CadastroAcesso
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public string? PermissaoNome { get; set; }

        public Medico? Medico { get; set; }

        public EnumStatusAcesso EnumStatusAcesso { get; set; }
        public CadastroAcesso()
        {
        }

        public CadastroAcesso(int id, string email, string nomeCompleto, string password, string confirmPassword, string permissaoNome, Medico? medico, EnumStatusAcesso enumStatusAcesso)
        {
            Id = id;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            PermissaoNome = permissaoNome;
            Medico = medico;
            EnumStatusAcesso = enumStatusAcesso;
            NomeCompleto = nomeCompleto;
        }
    }
}

using System.ComponentModel.DataAnnotations;
namespace Prontuario_do_Paciente_Online.Models.Enums
{
    public enum EnumStatusAcesso
    {
        [Display(Name = "Ativo")]
        Ativo = 1,

        [Display(Name = "Inativo")]
        Inativo = 2
    }
}

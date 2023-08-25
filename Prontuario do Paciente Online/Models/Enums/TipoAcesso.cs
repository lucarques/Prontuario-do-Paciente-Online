using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.Models.Enums
{
    public enum EnumTipoAcesso
    {
        [Display(Name = "Administrativo")]
        Administrativo = 1,

        [Display(Name = "Tecnologia")]
        Tecnologia = 2,

        [Display(Name = "Medico")]
        Medico = 3,

        [Display(Name = "Acompanhante")]
        Acompanhante = 4
    }
}

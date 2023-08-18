using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.Models.Enums
{
    public enum EnumStatus
    {
        [Display(Name = "Estavel")]
        Estavel = 3,

        [Display(Name = "Critico")]
        Critico = 2,

        [Display(Name = "Grave")]
        Grave = 1
    }
}

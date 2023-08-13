using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Prontuario_do_Paciente_Online.Models
{
    [Table("Acompanhante")]
    public class CadastroAcompanhante
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public char Sexo { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("Email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("Celular")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("UtilizarOnpront")]
        [Display(Name = "Utilizar OnPront")]
        public bool UtilizarApp { get; set; }
    }
}

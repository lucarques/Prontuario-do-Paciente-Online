using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prontuario_do_Paciente_Online.Models
{
    [Table("PacienteXAcompanhante")]
    public class PacienteXAcompanhante
    {
        [Column("Id")]
        [Display(Name ="Código")]
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

        [Column("Endereco")]
        [Display(Name = "Rua")]
        public string Endereco { get; set; }

        [Column("Numero")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Column("Motivo")]
        [Display(Name = "Motivo da internação")]
        public string Motivo { get; set; }

        [Column("NomeAcompanhante")]
        [Display(Name = "Nome")]
        public string NomeAcompanhante { get; set; }

        [Column("CPFAcompanhante")]
        [Display(Name = "CPF")]
        public string CPFAcompanhante { get; set; }

        [Column("Email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("Celular")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("GrauParentesco")]
        [Display(Name = "Grau de Parentesco")]
        public string GrauParentesco { get; set; }
    }
}

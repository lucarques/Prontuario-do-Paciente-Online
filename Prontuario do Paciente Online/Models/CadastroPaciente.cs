using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prontuario_do_Paciente_Online.Models
{
    [Table("Paciente")]
    public class CadastroPaciente
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

        [Column("Possui Acompanhante")]
        [Display(Name = "Possui Acompanhante")]
        public bool PossuiAcompanhante { get; set; }

    }
}

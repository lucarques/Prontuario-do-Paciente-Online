namespace Prontuario_do_Paciente_Online.Models
{
    public class CadastroAcompanhante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int NumeroTelefone { get; set; }
        public char UtilizarApp { get; set; }
    }
}

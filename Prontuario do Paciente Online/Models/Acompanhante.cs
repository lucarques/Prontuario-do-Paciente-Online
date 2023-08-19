namespace Prontuario_do_Paciente_Online.Models
{
    public class Acompanhante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string GrauParentesco { get; set; }
        public string Email { get; set; }
        public string SenhaAcessoAcompanhante { get; set; }

        public Acompanhante()
        {
        }

        public Acompanhante(int id, string nome, string cpf, string estado, string cidade, string endereco, int numero, string grauParentesco, string email, string senhaAcessoAcompanhante)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            GrauParentesco = grauParentesco;
            Email = email;
            SenhaAcessoAcompanhante = senhaAcessoAcompanhante;
        }

    }
}

﻿namespace Prontuario_do_Paciente_Online.Models
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
        public int GrauParentesco { get; set; }
        public string Email { get; set; }
        public string SenhaAcessoAcompanhante { get; set; }

    }
}
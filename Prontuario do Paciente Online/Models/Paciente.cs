using Prontuario_do_Paciente_Online.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string MotivoInternacao { get; set; }
        public Acompanhante Acompanhante { get; set; }
        public EnumStatus? StatusPaciente { get; set; }

        public Paciente()
        {
        }

        public Paciente(int id, string nome, string idade, string cpf, string estado, string cidade, string endereco, int numero, string motivoInternacao, Acompanhante acompanhante, EnumStatus statusPaciente)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            MotivoInternacao = motivoInternacao;
            Acompanhante = acompanhante;
            StatusPaciente = statusPaciente;
        }
    }
}


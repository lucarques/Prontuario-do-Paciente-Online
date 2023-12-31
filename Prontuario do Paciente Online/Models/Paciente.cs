﻿using Prontuario_do_Paciente_Online.Controllers;
using Prontuario_do_Paciente_Online.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string? Cid { get; set; }
        public string MotivoInternacao { get; set; }
        public DateTime DataInternacao { get; set; } = DateTime.UtcNow;
        public Acompanhante Acompanhante { get; set; }
        public EnumStatus? StatusPaciente { get; set; }
        public CadastroAcesso? CadastroAcesso { get; set; }
        public Prontuario? Prontuario { get; set; }
        public Paciente()
        {
        }

        public Paciente(int id, string nome, int idade, string cpf, string estado, string cidade, string endereco, int numero, string? cid, string motivoInternacao, DateTime dataInternacao, Acompanhante acompanhante, CadastroAcesso cadastroAcesso, EnumStatus? statusPaciente, Prontuario? prontuario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            Cid = cid;
            MotivoInternacao = motivoInternacao;
            DataInternacao = dataInternacao;
            Acompanhante = acompanhante;
            CadastroAcesso = cadastroAcesso;
            StatusPaciente = statusPaciente;
            Prontuario = prontuario;
        }
    }
}


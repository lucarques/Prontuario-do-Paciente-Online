﻿using Prontuario_do_Paciente_Online.Models.Enums;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public int Quarto { get; set; }
        public string Observacao { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public EnumStatus EnumStatus { get; set; }

        public Prontuario()
        {
        }

        public Prontuario(int id, string diagnostico, int quarto, string observacao, Medico medico, EnumStatus enumStatus, Paciente paciente)
        {
            Id = id;
            Diagnostico = diagnostico;
            Quarto = quarto;
            Observacao = observacao;
            Medico = medico;
            EnumStatus = enumStatus;
            Paciente = paciente;
        }
    }
}

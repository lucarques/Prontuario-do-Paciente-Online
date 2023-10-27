using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Services
{
    public class HomeService
    {
        private readonly Contexto _context;

        public HomeService(Contexto context)
        {
            _context = context;
        }

        public List<PacientesViewModelHome> ObterTodosPacienteComProntuarios()
        {
            DateTime dataInicio = DateTime.UtcNow.Date;

            var pacientesComProntuarios = _context.Paciente
                .Select(paciente => new
                {
                    Paciente = paciente,
                    UltimoProntuario = _context.Prontuario
                        .Where(prontuario => prontuario.PacienteId == paciente.Id && prontuario.DataProntuario.Date <= dataInicio)
                        .OrderByDescending(prontuario => prontuario.DataProntuario)
                        .FirstOrDefault()
                })
                .Where(pacienteProntuario => pacienteProntuario.UltimoProntuario != null)
                .Select(pacienteProntuario => new PacientesViewModelHome
                {
                    Paciente = new Paciente
                    {
                        Nome = pacienteProntuario.Paciente.Nome,
                        DataInternacao = pacienteProntuario.Paciente.DataInternacao
                    },
                    Prontuario = new Prontuario
                    {
                        Quarto = pacienteProntuario.UltimoProntuario.Quarto,
                        Diagnostico = pacienteProntuario.UltimoProntuario.Diagnostico,
                        EnumStatus = pacienteProntuario.UltimoProntuario.EnumStatus,
                        DataProntuario = pacienteProntuario.UltimoProntuario.DataProntuario
                    }
                })
                .ToList();

            return pacientesComProntuarios;
        }

        public Dictionary<string, int> ContarPacientesPorStatus(List<PacientesViewModelHome> pacientes)
        {
            var statusCounts = new Dictionary<string, int>
            {
                { EnumStatus.Grave.ToString(), 0 },
                { EnumStatus.Critico.ToString(), 0 },
                { EnumStatus.Estavel.ToString(), 0 }
            };

            foreach (var paciente in pacientes)
            {
                var statusStr = paciente.Prontuario.EnumStatus.ToString();
                if (statusCounts.ContainsKey(statusStr))
                {
                    statusCounts[statusStr]++;
                }
            }

            return statusCounts;
        }

        public PacientesViewModelHome ObterProntuarioDoPacientePorEmailAcompanhante(string email)
        {
            int idAcompanhante = _context.Acompanhante
                .Where(ac => ac.EmailAcompanhante == email)
                .Select(ac => ac.Id)
                .FirstOrDefault();

            int pacienteId = _context.Paciente
                .Where(p => p.Acompanhante.Id == idAcompanhante)
                .Select(p => p.Id)
                .FirstOrDefault();

            var prontuario = _context.Prontuario
                .Include(x => x.Paciente)
                .Include(x => x.Medico)
                .Where(x => x.PacienteId == pacienteId)
                .OrderByDescending(x => x.DataProntuario)
                .FirstOrDefault();

            var viewModel = new PacientesViewModelHome
            {
                Prontuario = new Prontuario
                {
                    Quarto = prontuario!.Quarto,
                    Diagnostico = prontuario.Diagnostico,
                    AvaliacaoMedico = prontuario.AvaliacaoMedico,
                    DataProntuario = prontuario.DataProntuario,
                    EnumStatus = prontuario.EnumStatus
                },
                Paciente = new Paciente
                {
                    Nome = prontuario.Paciente.Nome,
                    DataInternacao = prontuario.Paciente.DataInternacao
                },
                Medico = new Medico
                {
                    Crm = prontuario.Medico.Crm,
                    Nome = prontuario.Medico.Nome
                }
            };
            return viewModel;
        }


    }
}

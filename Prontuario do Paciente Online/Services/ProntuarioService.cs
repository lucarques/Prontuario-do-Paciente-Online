using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Models.Enums;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Services
{
    public class ProntuarioService
    {
        private readonly Contexto _context;

        public ProntuarioService(Contexto context)
        {
            _context = context;
        }

        public bool VerificaProntuarioExistenteHoje(int pacienteId)
        {
            DateTime dataHojeUtc = DateTime.Now.ToUniversalTime();
            return _context.Prontuario.Any(p => p.PacienteId == pacienteId && p.DataProntuario.Day == dataHojeUtc.Day);
        }

        public ProntuarioViewModel ObterDetalhesDoProntuario(int pacienteId)
        {
            DateTime dataHojeUtc = DateTime.Now.ToUniversalTime();

            var prontuario = _context.Prontuario
             .Include(x => x.Paciente)
             .Include(x => x.Medico)
             .FirstOrDefault(x => x.PacienteId == pacienteId && x.DataProntuario.Day == dataHojeUtc.Day);

            var viewModel = new ProntuarioViewModel
            {
                Quarto = prontuario!.Quarto,
                Diagnostico = prontuario.Diagnostico,
                AvaliacaoMedico = prontuario.AvaliacaoMedico,
                DataProntuario = prontuario.DataProntuario,
                Paciente = new Paciente
                {
                    Nome = prontuario.Paciente.Nome,
                    DataInternacao = prontuario.Paciente.DataInternacao
                },
                Medico = new Medico
                {
                    Crm = prontuario.Medico.Crm,
                    Nome = prontuario.Medico.Nome
                },
                EnumStatus = prontuario.EnumStatus
            };
            return viewModel;
        }

        public List<Paciente> ObterTodos()
        {
            return _context.Paciente.ToList();
        }

        public List<Prontuario> ObterTodosProntuario()
        {
            return _context.Prontuario.ToList();
        }

        public List<Medico> ObterTodosMedicos()
        {
            return _context.Medico.ToList();
        }

        public PacientesViewModel ObterPorPacienteId(int id)
        {
            var paciente = _context.Paciente.FirstOrDefault(x => x.Id == id);

            var viewModel = new PacientesViewModel
            {
                Id = id,
                Nome = paciente!.Nome,
                Idade = paciente.Idade,
                Cpf = paciente.Cpf,
                Estado = paciente.Estado,
                Cidade = paciente.Cidade,
                Endereco = paciente.Endereco,
                Numero = paciente.Numero,
                MotivoInternacao = paciente.MotivoInternacao,
                DataInternacao = paciente.DataInternacao,
            };
            return viewModel;
        }

        public bool InserirProntuario(ProntuarioCreateViewModel model)
        {
            try
            {
                var paciente = _context.Paciente.AsNoTracking().FirstOrDefault(p => p.Id == model.Paciente.Id);

                if (paciente == null)
                    return false;

                var novoProntuario = new Prontuario
                {
                    Quarto = model.Quarto,
                    Diagnostico = model.Diagnostico,
                    AvaliacaoMedico = model.AvaliacaoMedico,
                    DataProntuario = model.DataProntuario,
                    PacienteId = model.Paciente.Id,
                    MedicoId = model.Medico.Id,
                    EnumStatus = model.EnumStatus
                };

                _context.Prontuario.Add(novoProntuario);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    Console.WriteLine("Detalhes da exceção interna: " + ex.InnerException.Message);
                else
                    Console.WriteLine("Erro genérico: " + ex.Message);
                return false;
            }
        }
    }
}

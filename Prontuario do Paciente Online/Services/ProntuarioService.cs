using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
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

        public List<Paciente> ObterTodos()
        {
            return _context.Paciente.ToList();
        }

        public PacientesViewModel ObterPorPacienteId(int id)
        {
            var paciente = _context.Paciente.FirstOrDefault(x => x.Id == id);

            var viewModel = new PacientesViewModel
            {
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
    }
}

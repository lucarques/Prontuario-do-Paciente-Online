using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;

namespace Prontuario_do_Paciente_Online.Services
{
    public class PacienteService
    {
        private readonly Contexto _context;
        public PacienteService(Contexto context)
        {
            _context = context;
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _context.Paciente.ToList();
        }

        public IEnumerable<Paciente> ObterDetalhes(int id)
        {
            return _context.Paciente.Include(x => x.Acompanhante).ToList();
        }
    }
}

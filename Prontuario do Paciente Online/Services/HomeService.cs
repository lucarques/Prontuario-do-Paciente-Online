using Prontuario_do_Paciente_Online.Models;
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
                .Where(paciente => paciente.Prontuario.DataProntuario.Date == dataInicio)
                .Select(paciente => new PacientesViewModelHome
                {
                    Paciente = new Paciente
                    {
                        Nome = paciente.Nome,
                        DataInternacao = paciente.DataInternacao
                    },
                    Prontuario = new Prontuario
                    {
                        Quarto = paciente.Prontuario.Quarto,
                        Diagnostico = paciente.Prontuario.Diagnostico,
                        EnumStatus = paciente.Prontuario.EnumStatus,
                        DataProntuario = paciente.Prontuario.DataProntuario
                    }
                })
                .ToList();

            return pacientesComProntuarios;
        }

    }
}

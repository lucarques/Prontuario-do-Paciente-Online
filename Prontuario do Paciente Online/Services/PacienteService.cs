using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.ViewModels;

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

        public PacientesViewModel ObterDetalhes(int id)
        {
            var paciente = _context.Paciente.Include(x => x.Acompanhante).FirstOrDefault(x => x.Id == id);

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

                Acompanhante = new AcompanhanteViewModel
                {
                    NomeAcompanhante = paciente.Acompanhante.NomeAcompanhante,
                    CpfAcompanhante = paciente.Acompanhante.CpfAcompanhante,
                    EstadoAcompanhante = paciente.Acompanhante.EstadoAcompanhante,
                    CidadeAcompanhante = paciente.Acompanhante.CidadeAcompanhante,
                    EnderecoAcompanhante = paciente.Acompanhante.EnderecoAcompanhante,
                    NumeroAcompanhante = paciente.Acompanhante.NumeroAcompanhante,
                    GrauParentesco = paciente.Acompanhante.GrauParentesco,
                }
            };
            return viewModel;
        }

        public void CadastrarPaciente(PacientesViewModel model)
        {
            try
            {
                Paciente novoPaciente = new Paciente
                {
                    Nome = model.Nome!,
                    Idade = model.Idade!,
                    Cpf = model.Cpf!,
                    Estado = model.Estado!,
                    Cidade = model.Cidade!,
                    Endereco = model.Endereco!,
                    Numero = model.Numero!,
                    MotivoInternacao = model.MotivoInternacao!,
                    DataInternacao = model.DataInternacao!,
                    Acompanhante = new Acompanhante
                    {
                        NomeAcompanhante = model.Acompanhante!.NomeAcompanhante,
                        CpfAcompanhante = model.Acompanhante!.CpfAcompanhante,
                        EstadoAcompanhante = model.Acompanhante!.EstadoAcompanhante,
                        CidadeAcompanhante = model.Acompanhante!.CidadeAcompanhante,
                        EnderecoAcompanhante = model.Acompanhante!.EnderecoAcompanhante,
                        NumeroAcompanhante = model.Acompanhante!.NumeroAcompanhante,
                        GrauParentesco = model.Acompanhante!.GrauParentesco,
                    }
                };

                _context.Paciente.Add(novoPaciente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Detalhes da exceção interna: " + ex.InnerException.Message);
                }
                else
                {
                    Console.WriteLine("Erro genérico: " + ex.Message);
                }
            }
        }
    }
}

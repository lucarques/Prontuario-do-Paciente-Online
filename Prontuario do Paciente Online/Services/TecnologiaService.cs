using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Services
{
    public class TecnologiaService
    {
        private readonly Contexto _context;
        public TecnologiaService(Contexto context)
        {
            _context = context;
        }
        public List<CadastroAcesso> ObterTodos()
        {
            return _context.CadastroAcesso.ToList();
        }
        public void CadastroNovoMedico(CadastroAcessoViewModel model)
        {
            if (model.Medico == null || string.IsNullOrEmpty(model.Medico.Nome) || string.IsNullOrEmpty(model.Medico.Crm))
            {
                throw new ArgumentException("Os dados do médico são inválidos.");
            }

            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    var medico = new Medico
                    {
                        Nome = model.Medico.Nome,
                        Crm = model.Medico.Crm
                    };

                    _context.Medico.Add(medico);
                    _context.SaveChanges();

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção durante o cadastro do médico: {ex.Message}");
                throw;
            }
        }

        public CadastroAcesso ObterDetalhesPorId(int id)
        {
            var cadastroAcesso = _context.CadastroAcesso.FirstOrDefault(x => x.Id == id);

            var viewModel = new CadastroAcesso
            {
                NomeCompleto = cadastroAcesso!.NomeCompleto,
                Email = cadastroAcesso.Email,
                PermissaoNome = cadastroAcesso.PermissaoNome,
                EnumStatusAcesso = cadastroAcesso.EnumStatusAcesso
            };

            return viewModel;
        }


        public List<CadastroAcesso> ObterPorTipoAcesso(string acesso)
        {
            return _context.CadastroAcesso.Where(x => x.PermissaoNome == acesso).ToList();
        }
    }
}


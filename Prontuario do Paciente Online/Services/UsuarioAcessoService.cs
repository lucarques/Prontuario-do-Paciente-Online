using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Services
{
    public class UsuarioAcessoService
    {
        private readonly Contexto _context;

        public UsuarioAcessoService(Contexto context)
        {
            _context = context;
        }

        //Tela de Listagem de Usuarios Cadastrados (Index) > Ao carregar.
        public IEnumerable<UsuarioAcesso> ObterUsuariosCadastrados()
        {
            return _context.UsuarioAcesso.ToList();
        }

        public void CadastrarUsuarioAcesso(UsuarioAcessoViewModel model)
        {
            try
            {
                UsuarioAcesso novoUsuario = new UsuarioAcesso
                {
                    Usuario = model.Usuario,
                    Email = model.Email,
                    SenhaAcesso = model.SenhaAcesso,
                    TipoAcesso = model.TipoAcesso
                };

                _context.UsuarioAcesso.Add(novoUsuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


    }
}

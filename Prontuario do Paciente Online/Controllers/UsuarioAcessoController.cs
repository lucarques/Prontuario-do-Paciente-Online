using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    public class UsuarioAcessoController : Controller
    {
        private readonly UsuarioAcessoService _usuarioAcessoService;

        public UsuarioAcessoController(UsuarioAcessoService usuarioAcessoService)
        {
            _usuarioAcessoService = usuarioAcessoService;
        }
        public ActionResult Index()
        {
            var list = _usuarioAcessoService.ObterUsuariosCadastrados();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioAcessoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioAcessoService.CadastrarUsuarioAcesso(model);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o usuário, detalhe do erro: {erro.Message}";
                return View(model);
            }
            
        }
    }
}

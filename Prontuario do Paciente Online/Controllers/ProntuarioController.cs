using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles ="Medico, Tecnologia")]
   
    public class ProntuarioController : Controller
    {
        private readonly ProntuarioService _prontuarioService;

        public ProntuarioController(ProntuarioService prontuarioService)
        {
            _prontuarioService = prontuarioService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var list = _prontuarioService.ObterTodos();
            return View(list);
        }

        [HttpGet]
        public ActionResult ObterTodosMedicos()
        {
            var list = _prontuarioService.ObterTodosMedicos();
            return Json(list);
        }

        [HttpGet]
        public ActionResult AdicionarProntuario(int id)
        {
            var dados = _prontuarioService.ObterDadosIniciaisProntuarioPorPaciente(id);
            if (ModelState.IsValid)
            {
                return PartialView("_AdicionarProntuarioPaciente", dados);
            }
            return View(dados);
        }

        [HttpPost]
        public ActionResult InserirProntuario(ProntuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _prontuarioService.InserirProntuario(model);
                    return RedirectToAction("Sucesso");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ocorreu um erro ao inserir o prontuário: " + ex.Message);
                }
            }
            return View(model);
        }

    }
}

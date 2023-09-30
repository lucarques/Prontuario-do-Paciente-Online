using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles = "Medico, Tecnologia")]

    public class ProntuarioController : Controller
    {
        private readonly ProntuarioService _prontuarioService;
        private readonly PacienteService _pacienteService;

        public ProntuarioController(ProntuarioService prontuarioService, PacienteService pacienteService)
        {
            _prontuarioService = prontuarioService;
            _pacienteService = pacienteService;
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
            var paciente = _pacienteService.ObterDetalhes(id);

            var model = new ProntuarioCreateViewModel
            {
                PacienteId = id,
                PacienteNome = paciente.Nome,
                PacienteDataInternacao = paciente.DataInternacao
            };

            return PartialView("_AdicionarProntuarioPaciente", model);
        }

        [HttpPost]
        public IActionResult InserirProntuario(ProntuarioCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _prontuarioService.InserirProntuario(model);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ocorreu um erro ao inserir o prontuário: " + ex.Message);
                }
            }
            return RedirectToAction("Index");
        }

    }
}

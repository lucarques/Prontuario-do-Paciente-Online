using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles = "Admin, Tecnologia")]
    public class PacientesController : Controller
    {
        private readonly PacienteService _pacienteService;
        public PacientesController(PacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public ActionResult Index()
        {
            var list = _pacienteService.ObterTodos();
            return View(list);
        }

        public ActionResult Details(int id)
        {
            var list = _pacienteService.ObterDetalhes(id);
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacientesViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pacienteService.CadastrarPaciente(model);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View(model);
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

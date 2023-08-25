using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    public class PacientesController : Controller
    {
        private readonly PacienteService _pacienteService;
        public PacientesController(PacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET: PacienteController
        public ActionResult Index()
        {
            var list = _pacienteService.ObterTodos();
            return View(list);
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(int id)
        {
            var list = _pacienteService.ObterDetalhes(id);
            return View(list);
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
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

        // GET: PacienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PacienteController/Edit/5
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

        // GET: PacienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PacienteController/Delete/5
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

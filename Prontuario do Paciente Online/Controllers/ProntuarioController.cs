using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Services;

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
        public ActionResult AdicionarProntuario(int id)
        {
            var dados = _prontuarioService.ObterPorPacienteId(id);
            return PartialView("_AdicionarProntuarioPaciente",dados);
        }
    }
}

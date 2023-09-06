using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles ="Medico, Tecnologia")]
    public class ProntuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles = "Tecnologia, Acompanhante")]
    public class AcompanhanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

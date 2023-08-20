using Microsoft.AspNetCore.Mvc;

namespace Prontuario_do_Paciente_Online.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

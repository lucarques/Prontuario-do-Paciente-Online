using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;
using System.Diagnostics;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeService _homeService;

        public HomeController(ILogger<HomeController> logger,HomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public ActionResult Index()
        {
            var PacientesComProntuario = _homeService.ObterTodosPacienteComProntuarios();

            var modelList = PacientesComProntuario.Select(pacienteProntuario => new PacientesViewModelHome
            {
                Paciente = new Paciente
                {
                    Nome = pacienteProntuario.Paciente.Nome,
                    DataInternacao = pacienteProntuario.Paciente.DataInternacao
                },
                Prontuario = new Prontuario
                {
                    Quarto = pacienteProntuario.Prontuario.Quarto,
                    Diagnostico = pacienteProntuario.Prontuario.Diagnostico,
                    EnumStatus = pacienteProntuario.Prontuario.EnumStatus,
                    DataProntuario = pacienteProntuario.Prontuario.DataProntuario

                }
            }).ToList();

            return View(modelList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    public class TecnologiaController : Controller
    {
        private readonly TecnologiaService _tecnologiaService;
        private readonly PacienteService _pacienteService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public TecnologiaController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, TecnologiaService tecnologiaService, PacienteService pacienteService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _tecnologiaService = tecnologiaService;
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var users = _tecnologiaService.ObterTodos();
            return View(users);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = _tecnologiaService.ObterDetalhesPorId(id);
            return View(user);
        }

        [HttpGet]
        public ActionResult ObterPorTipoAcesso(string tipoAcesso)
        {
            var result = _tecnologiaService.ObterPorTipoAcesso(tipoAcesso);
            return Json(result);
        }

        [HttpGet]
        public IActionResult RegistrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarUsuario(CadastroAcessoViewModel model)
        {
            try
            {
                if (ModelState.IsValid || (model.Medico.Nome == null))
                {
                    var acesso = new CadastroAcesso()
                    {
                        NomeCompleto = model.NomeCompleto,
                        Email = model.Email,
                        EnumStatusAcesso = model.EnumStatusAcesso,
                        PermissaoNome = model.PermissaoNome,
                    };

                    _pacienteService.CadastrarAcesso(acesso);

                    var user = new IdentityUser
                    {
                        UserName = model.Email,
                        Email = model.Email
                    };

                    if (model.Medico.Nome != null)
                    {
                        try
                        {
                            _tecnologiaService.CadastroNovoMedico(model);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ocorreu uma exceção durante o cadastro do médico: {ex.Message}");
                        }
                    }

                    var result = await userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        var role = await roleManager.FindByNameAsync(model.PermissaoNome);
                        if (role != null)
                            await userManager.AddToRoleAsync(user, role.Name);
                        return RedirectToAction("Index", "Home");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);

                }
            }
            catch
            {
                return View(model);
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuário com ID = {id} não foi encontrado";
                return View("NotFound");
            }

            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                return View("Index");
            }
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.Services;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Controllers
{
    [Authorize(Roles = "Admin, Tecnologia")]
    public class PacientesController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly PacienteService _pacienteService;
        public PacientesController(PacienteService pacienteService, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _pacienteService = pacienteService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public ActionResult Index()
        {
            var list = _pacienteService.ObterTodos();
            return View(list);
        }

        public ActionResult Details(int id)
        {
            var dados = _pacienteService.ObterDetalhes(id);
            return View(dados);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PacientesViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var acesso = new CadastroAcesso
                    {
                        NomeCompleto = model.CadastroAcesso.NomeCompleto,
                        Email = model.CadastroAcesso.Email,
                        PermissaoNome = model.CadastroAcesso.PermissaoNome,
                        EnumStatusAcesso = model.CadastroAcesso.EnumStatusAcesso
                    };

                    _pacienteService.CadastrarAcesso(acesso);

                    var user = new IdentityUser
                    {
                        UserName = model.CadastroAcesso.Email,
                        Email = model.CadastroAcesso.Email
                    };

                    var result = await userManager.CreateAsync(user, model.CadastroAcesso.Password);

                    if (result.Succeeded)
                    {
                        var role = await roleManager.FindByNameAsync(model.CadastroAcesso.PermissaoNome);
                        if (role != null)
                            await userManager.AddToRoleAsync(user, role.Name);
                        _pacienteService.CadastrarPaciente(model);

                        return RedirectToAction("Index");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            var dados = _pacienteService.ObterDetalhes(id);
            return View(dados);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PacientesViewModel model)
        {
            try
            {
                _pacienteService.AtualizarDadosPaciente(model);
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

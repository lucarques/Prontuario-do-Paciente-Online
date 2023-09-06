using Microsoft.AspNetCore.Identity;

namespace Prontuario_do_Paciente_Online.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            if (! await _roleManager.RoleExistsAsync("Admin"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Tecnologia"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Tecnologia";
                role.NormalizedName = "TECNOLOGIA";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Medico"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Medico";
                role.NormalizedName = "MEDICO";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Acompanhante"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Acompanhante";
                role.NormalizedName = "ACOMPANHANTE";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }
        }

        public async Task SeedUserAsync()
        {
            if(await _userManager.FindByEmailAsync("admin@localhost") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin@localhost";
                user.Email = "admin@localhost";
                user.NormalizedUserName = "ADMIN@LOCALHOST";
                user.NormalizedEmail = "ADMIN@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "@Patoroxo1224");

                if(result.Succeeded) 
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }

            if (await _userManager.FindByEmailAsync("tecnologia@localhost") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "tecnologia@localhost";
                user.Email = "tecnologia@localhost";
                user.NormalizedUserName = "TECNOLOGIA@LOCALHOST";
                user.NormalizedEmail = "TECNOLOGIA@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "@Patoroxo1224");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Tecnologia");
                }
            }

            if (await _userManager.FindByEmailAsync("medico@localhost") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "medico@localhost";
                user.Email = "medico@localhost";
                user.NormalizedUserName = "MEDICO@LOCALHOST";
                user.NormalizedEmail = "MEDICO@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "@Patoroxo1224");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Medico");
                }
            }

            if (await _userManager.FindByEmailAsync("acompanhante@localhost") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "acompanhante@localhost";
                user.Email = "acompanhante@localhost";
                user.NormalizedUserName = "ACOMPANHANTE@LOCALHOST";
                user.NormalizedEmail = "ACOMPANHANTE@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "@Patoroxo1224");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Acompanhante");
                }
            }
        }
    }
}

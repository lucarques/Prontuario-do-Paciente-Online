namespace Prontuario_do_Paciente_Online.Services
{
    public interface ISeedUserRoleInitial
    {
        Task SeedRolesAsync();
        Task SeedUserAsync();
    }
}

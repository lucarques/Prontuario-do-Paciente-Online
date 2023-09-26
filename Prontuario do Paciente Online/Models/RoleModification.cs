namespace Prontuario_do_Paciente_Online.Models
{
    public class RoleModification
    {
        public string? RoleName { get; set; }
        public string? RoleId { get; set;}
        public string[]? AddIds { get; set; }
        public string[]? DeleteIds { get; set; }
    }
}

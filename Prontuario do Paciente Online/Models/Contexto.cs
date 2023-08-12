using Microsoft.EntityFrameworkCore;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base (options) 
        {
        }

        public DbSet<CadastroPaciente> Pacientes { get; set; }
    }
}

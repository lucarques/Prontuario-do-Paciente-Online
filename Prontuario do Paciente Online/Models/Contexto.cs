using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base (options) 
        {
        }

        public DbSet<PacienteXAcompanhante> Pacientes { get; set; }

    }
}

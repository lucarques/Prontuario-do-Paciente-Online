﻿using Microsoft.EntityFrameworkCore;
using Prontuario_do_Paciente_Online.Models;
using Prontuario_do_Paciente_Online.ViewModels;

namespace Prontuario_do_Paciente_Online.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base (options) 
        {
        }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Acompanhante> Acompanhante { get; set; }
    }
}
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Models;

namespace SistemaAcademia.Data
{
    public class SistemaAcademiaContext : DbContext
    {
        public SistemaAcademiaContext(DbContextOptions<SistemaAcademiaContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Ficha> Ficha { get; set; }
    
    }
}

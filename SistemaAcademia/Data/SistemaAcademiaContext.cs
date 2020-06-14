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
        public SistemaAcademiaContext (DbContextOptions<SistemaAcademiaContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAcademia.Models.Department> Department { get; set; }
    }
}

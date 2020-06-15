using SistemaAcademia.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademia.Models
{
    public class Ficha
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Aluno Aluno { get; set; }
        public Professor Professor { get; set; }
        public FichaStatus Status { get; set; }
        public int Total { get; set; }
        public Ficha()
        {
        }

        public Ficha(int id, DateTime data, DateTime inicio, DateTime fim, Aluno aluno, Professor professor, FichaStatus status, int total)
        {
            Id = id;
            Data = data;
            Inicio = inicio;
            Fim = fim;
            Aluno = aluno;
            Professor = professor;
            Status = status;
            Total = total;
        }
    }
}

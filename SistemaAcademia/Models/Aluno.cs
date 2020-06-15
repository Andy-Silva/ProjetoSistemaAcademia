using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademia.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataAniversario { get; set; }
        public Departamento Departamento { get; set; }
        public int Total { get; set; }
        public Aluno()
        {

        }

        public Aluno(int id, string nome, DateTime data, DateTime dataAniversario, Departamento departamento, int total)
        {
            Id = id;
            Nome = nome;
            Data = data;
            DataAniversario = dataAniversario;
            Departamento = departamento;
            Total = total;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademia.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Professor> Professores { get; set; } = new List<Professor>();
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddProfessor(Professor professor)
        {
            Professores.Add(professor);
        }

        public void RemoveProfessor(Professor professor)
        {
            Professores.Remove(professor);
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoveAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

        public int TotalAlunos(DateTime inicio, DateTime fim)
        {
            return Alunos.Where(al => al.Data >= inicio && al.Data <= fim).Sum(al => al.Total);
        }
    }
}

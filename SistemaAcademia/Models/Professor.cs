using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademia.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAniversario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
        public Professor()
        {
        }

        public Professor(int id, string nome, DateTime dataAniversario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            DataAniversario = dataAniversario;
            Departamento = departamento;
        }

        public void AddFichas(Ficha fi)
        {
            Fichas.Add(fi);
        }  

        public void RemoveFichas(Ficha fi)
        {
            Fichas.Remove(fi);
        }

        public int TotalFichas(DateTime inicio, DateTime fim)
        {
            return Fichas.Where(fi => fi.Data >= inicio && fi.Data <= fim).Sum(fi => fi.Total);
        }
        public int TotalAlunos(DateTime inicio, DateTime fim)
        {
            return Alunos.Where(al => al.Data >= inicio && al.Data <= fim).Sum(al => al.Total);
        }
    }
}

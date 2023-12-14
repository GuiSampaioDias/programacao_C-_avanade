using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOEXPLORANDO.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        
        public void AdicionarAluno(Pessoa aluno)// nesse caso não tem o retorno pq estamos apenas adicionando na lista para isso usamos o void
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;      
        }
        
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N° " + (count + 1) + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
        }
    }
}
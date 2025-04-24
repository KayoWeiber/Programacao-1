using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula24_04_25
{
    internal class Program
    {
        //class Aluno
        //{
        //    public string nome { get; set; }
        //    public double nota { get; set; }

        //    public Aluno(string nome, double nota)
        //    {
        //        this.nome = nome;
        //        this.nota = nota;
        //    }
        //    public void exibir()
        //    {
        //        Console.WriteLine($"Aluno {nome}, Nota {nota}");         
        //    }
        //}
        class Livro
        {
            public string titulo {  get; set; }
            public string autor {  get; set; }

            public Livro (string titulo, string autor)
            {
                this.titulo=titulo;
                this.autor=autor;
            }
            public void exibir()
            {
                Console.WriteLine($"Titulo: {titulo}, Autor: {autor}");
            }
        }
        static void Main(string[] args)
        {
            //Aluno[] alunos = new Aluno[3];

            //alunos[2] = new Aluno("Kayo", 10);
            //alunos[0] = new Aluno("JOhn",8.5);
            //alunos[1] = new Aluno("Diego", 2.7);

            //for (int i = 0; i < alunos.Length; i++)
            //{
            //    alunos[i].exibir();
            //}
            Livro[] livros = new Livro[4];
            livros[3] = new Livro("O Combate", "John Bola");
            livros[1] = new Livro("Dev de IA", "Mike");
            livros[2] = new Livro("O casado", "Kayo");
            livros[0] = new Livro("Código Limpo", "Fulano");

            foreach (Livro i in livros)
            {
                i.exibir();
            }
        }
    }
}

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
        //class Livro
        //{
        //    public string titulo {  get; set; }
        //    public string autor {  get; set; }

        //    public Livro (string titulo, string autor)
        //    {
        //        this.titulo=titulo;
        //        this.autor=autor;
        //    }
        //    public void exibir()
        //    {
        //        Console.WriteLine($"Titulo: {titulo}, Autor: {autor}");
        //    }
        //}

        //class Filme 
        //{ 
        //    public string titulo { get; set; }
        //    public int ano { get; set; }

        //    public Filme(string titulo, int ano)
        //    {
        //        this.titulo = titulo;
        //        this.ano = ano;
        //    }
        //    public void Exibir()
        //    {
        //        Console.WriteLine($"Titulo: {titulo}, Ano: {ano}");
        //    }
        //}

        //class Pessoa
        //{
        //    public string nome { get; set; }
        //    public int idade { get; set; }

        //    public Pessoa (string nome, int idade)
        //    {
        //        this.nome = nome;
        //        this.idade = idade;
        //    }
        //    public void Exibir()
        //    {
        //        Console.WriteLine($"Nome: {nome}, idade: {idade}");
        //    }
        // }
        class Produto
        {
            public string nome { get; set; }
            public double preco { get; set; }

            public Produto(string nome, double preco) { 
            this.nome = nome;
            this.preco = preco;
            }
            public PrecoComDesconto(double percentual)
            {
              Console.WriteLine($"")
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

            //Livro[] livros = new Livro[4];
            //livros[3] = new Livro("O Combate", "John Bola");
            //livros[1] = new Livro("Dev de IA", "Mike");
            //livros[2] = new Livro("O casado", "Kayo");
            //livros[0] = new Livro("Código Limpo", "Fulano");

            //foreach (Livro i in livros)
            //{
            //    i.exibir();
            //}

            //Filme[] filmes = new Filme[3];
            //filmes[2] = new Filme("Tropa de elite", 2012);
            //filmes[1] = new Filme("Moana 2", 2025);
            //filmes[0] = new Filme("Minecraft", 2025);

            //for (int i = 0; i < filmes.Length; i++) { 
            //    filmes[i].Exibir();
            //}

            //Pessoa[] pessoas = new Pessoa[4];
            //pessoas[0] = new Pessoa("Kayo",20);
            //pessoas[1] = new Pessoa("John", 15);
            //pessoas[2] = new Pessoa("Pedro", 18);
            //pessoas[3] = new Pessoa("Jorge", 19);

            //foreach (Pessoa pe in pessoas)
            //{
            //    pe.Exibir();
            //}


        }
    }
}

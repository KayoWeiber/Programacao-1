using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kayo_10_04_2025
{
    internal class Program
    {
        //public class Pessoa
        //{
        //    public string nome { get; set; }
        //    public int idade { get; set; }

        //    public void apresentar()
        //    {
        //        Console.WriteLine("Olá meu nome é "+this.nome+" e tenho " + idade+" anos");
        //        //Console.WriteLine($"Meu nome é {nome}")
        //    }
        //    public int AnoNascimento()
        //    {
        //        int resposta = 2025- this.idade;
        //        return resposta;
        //    }
        //    public Pessoa()
        //    {
        //        Console.Write("Digite o nome da pessoa: ");
        //        this.nome = Console.ReadLine();
        //        Console.Write("Digite a idade: ");
        //        this.idade = int.Parse(Console.ReadLine());
        //    }
        //    ~Pessoa()
        //    {
        //        Console.WriteLine("O Objeto foi destruido");
        //    }
        //}
        public class Livro
        {
            public string titulo { get; set; }
            public string autor { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"O Titulo do Livro é {this.titulo} e o Autor é {this.autor}");
            }
        }
        static void Main(string[] args)
        {

            //int resp;
            //int resp2;
            //Pessoa p1 = new Pessoa();
            ////p1.nome = "Kayo Weiber";
            ////p1.idade = 20;
            ////p1.apresentar();

            //Pessoa p2 = new Pessoa();
            ////Console.Write("Informe o nome da pessoa 2: ");
            ////p2.nome = Console.ReadLine();
            ////p2.idade = 20;
            ////p2.apresentar();

            //resp = p1.AnoNascimento();
            //resp2 = p2.AnoNascimento();
            //Console.WriteLine($"Resp: {resp}");
            //Console.WriteLine($"Resp2: {resp2}");
            Livro l1 = new Livro();
            l1.titulo = "Codificador Limpo";
            l1.autor = "Alguem";
            l1.ExibirInformacoes();
        }
    }
}

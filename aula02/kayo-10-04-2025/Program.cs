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


        //public class Livro
        //{
        //    public string titulo { get; set; }
        //    public string autor { get; set; }

        //    public void ExibirInformacoes()
        //    {
        //        Console.WriteLine($"O Titulo do Livro é {this.titulo} e o Autor é {this.autor}");
        //    }
        //}
        //public class Filme
        //{
        //    public string nome {  get; set; }
        //    public int anoLancamento { get; set; }

        //    public void MostrarDetalhes()
        //    {
        //        Console.WriteLine($"O nome do filme é {nome} e o ano de lançamento é {anoLancamento}");
        //    }
        //}
        //public class cidade
        //{
        //    public string nome { get; set; }
        //    public string estado { get; set; }
        //    public void ExibirCidade()
        //    {
        //        Console.WriteLine($"O Nome da cidade é {nome} do estado {estado}");
        //    }
        //}

        //public class musica
        //{
        //    public string titulo {  get; set; }
        //    public string cantor {  get; set; }
        //    public void TocarMusica()
        //    {
        //        Console.WriteLine($"Titulo da musica tocando é {titulo} do cantor {cantor}");
        //    }
        //}

        //public class pessoa
        //{
        //    public string nome { get; set; }
        //    public int idade { get; set; }
        //    public void apresentar()
        //    {
        //        Console.WriteLine($"Olá meu nome é {nome} e tenho {idade}");
        //    }
        //}
        //public class produto
        //{
        //    public string nome { get; set; }
        //    public double preco { get; set; }
        //    public void ExibirProduto()
        //    {
        //        Console.WriteLine($"O nome do produto é {nome} com o valor {preco}");
        //    }
        //}
        //public class aluno
        //{
        //    public string nome { get; set; }
        //    public decimal nota { get; set; }
        //    public void MostrarNota()
        //    {
        //        Console.WriteLine($"O Aluno {nome} está com a nota {nota}");
        //    }
        //}
        
        //public class retangulo
        //{
        //    public double Base { get; set; }
        //    public double altura { get; set; }
        //    public void CalcularArea()
        //    {
        //        Console.WriteLine($"A Área é {Base*altura}");
        //    }
        //}

        public class Mensagem
        {
            public string nome { get; set; }

            public void saudacao()
            {
                Console.Write("Digite o seu nome: ");
                this.nome=Console.ReadLine();
                Console.WriteLine($"Olá {this.nome}, seja bem vindo!!");
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



            //Livro l1 = new Livro();
            //l1.titulo = "Codificador Limpo";
            //l1.autor = "Alguem";
            //l1.ExibirInformacoes();

            //Filme f1 = new Filme();
            //f1.nome = "Tropa de Elite";
            //f1.anoLancamento = 2010;
            //f1.MostrarDetalhes();

            //cidade c1 = new cidade();
            //c1.nome = "Planura";
            //c1.estado = "Minas Gerais";
            //c1.ExibirCidade();

            //musica m1 = new musica();
            //m1.titulo = "Investe em mim";
            //m1.cantor = "Balões da pisadinha";
            //m1.TocarMusica();

            //pessoa pTeSTE = new pessoa();
            //pTeSTE.nome = "Kayo";
            //pTeSTE.idade = 20;
            //pTeSTE.apresentar();

            //produto p1 = new produto();
            //p1.nome = "Veja";
            //p1.preco = 2.99;

            //p1.ExibirProduto();

            //aluno aluno = new aluno();
            //aluno.nome = "Kayo";
            //aluno.nota = 20;
            //aluno.MostrarNota();

            //retangulo r1 = new retangulo();
            //r1.Base = 10;
            //r1.altura = 7;
            //r1.CalcularArea();

            Mensagem m1 = new Mensagem();
            m1.saudacao();
        }
    }
}

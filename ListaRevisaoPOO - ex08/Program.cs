using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elabore um sistema simples com as classes `Livro` e `Biblioteca`, em arquivos separados.
            //A classe `Livro` deve conter `titulo` e `autor`, enquanto a `Biblioteca` deve conter um vetor de até 4 livros e métodos para `Cadastrar()` e `ExibirTodos()`.
            //Monte um menu para acessar essas opções.
            Biblioteca livros = new Biblioteca();
            int opcao = 0;
            do
            {
                Console.Write("\nMenu:\n1 - Cadastrar Livro\n2 - Listar Livro\n3 - Sair\nEscolha a opção: "); opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        livros.Cadastrar();
                        break;
                    case 2:
                        livros.ExibirTodos();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            }
            while (opcao!=3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03_aula_08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            int opcao;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Buscar Livro por Autor");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        biblioteca.AdicionarLivro();
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        biblioteca.BuscarPorAutor();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 4);
        }
    }
}

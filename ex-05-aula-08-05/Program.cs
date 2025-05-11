using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05_aula_08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int opcao;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar produto");
                Console.WriteLine("2. Listar produtos");
                Console.WriteLine("3. Atualizar produto");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        estoque.adicionarProduto();
                        break;
                    case 2:
                        estoque.listarProdutos();
                        break;
                    case 3:
                        estoque.atualizarProduto();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 4);
        }
    }
}

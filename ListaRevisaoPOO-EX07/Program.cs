using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            controleProduto controle = new controleProduto();
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Calcular Valor Total em Estoque por produto");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        controle.cadastrarProduto();
                        break;
                    case 2:
                        controle.calcular();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 3);
        }
    }
}

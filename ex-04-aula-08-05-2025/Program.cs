using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_aula_08_05_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorFuncionario gerenciador = new GerenciadorFuncionario();
            int opcao = 0;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Cadastrar Funcionario");
                Console.WriteLine("2 - Listar Funcionarios");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opcao: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        gerenciador.cadastrarFuncionario();
                        break;
                    case 2:
                        gerenciador.listarFuncionarios();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != 3);
        }
    }
}

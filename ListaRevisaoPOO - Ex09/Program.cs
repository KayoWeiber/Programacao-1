using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControleFuncionario controle = new ControleFuncionario();
            int opcao;
            do
            {
                Console.Write($"\nMenu:\n1 - Adicionar Funcionario \n2 - Listar funcionarios \n3 - Sair\nDigite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        controle.AdicionarFuncionario();
                        break;
                    case 2:
                        controle.ExibirFuncionarios();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            } while (opcao != 3);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02_aula08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Sistema de Veículos:Crie a classe Veiculo com atributos privados modelo, marca e ano. A classe Frota deve permitir o cadastro de até 5 veículos e listá - los
            //Crie um menu com as opções: Cadastrar / Listar / Sair.

            frota frota = new frota();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cadastrar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        frota.CadastrarVeiculo();
                        break;
                    case 2:
                        frota.ListarVeiculos();
                        break;
                    case 3:
                        Console.WriteLine("Programa encerrado!");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_05_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a classe `Aluno` com atributos privados `nome` e `nota`,
            //um constructor que preencha esses parâmetros, e o método `Exibir()`.
            //Crie uma segunda classe chamada `Turma` que armazene até 3 alunos e forneça os métodos `Cadastrar()` e `Listar()`.
            //Crie um menu na classe `Program` com as opções: 1 - Cadastrar, 2 - Listar, 3 - Sair.

            turma t = new turma();
            int opcao = 0;

            do 
            {
                Console.Write("Menu:\n1 - Cadastrar\n2 - Listar\n3 - Sair\nEscolha uma opção:");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        t.cadastrar();
                        break;
                    case 2:
                        t.listar();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 3);
        }
    }
}

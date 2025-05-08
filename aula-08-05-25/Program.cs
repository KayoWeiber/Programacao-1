using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08_05_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadastrarPessoa cadastro = new CadastrarPessoa();
            int opcao;

            do
            {
                Console.WriteLine("\n1 -  Cadastrar Pessoa");
                Console.WriteLine("2 -  Listar Pessoas");
                Console.WriteLine("3 -  Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome: "); string nome = Console.ReadLine();
                    Console.WriteLine("Digite a idade: "); int idade = int.Parse(Console.ReadLine());
                    cadastro.Cadastrar(nome, idade);
                }
                else if (opcao == 2)
                {
                    cadastro.Lista();
                }

            } while (opcao !=3);
        }
    }
}

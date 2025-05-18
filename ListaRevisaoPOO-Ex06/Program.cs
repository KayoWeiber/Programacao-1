using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma(); //tem que interligar a classe turma
            int opcao = 0;
            do
            {
                Console.Write("\nMenu:\n1 - Cadastrar\n2 - Listar\n3 - Sair\nEscolhar a opção: "); opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        turma.Cadastrar();
                        break;
                    case 2:
                        turma.Listar();
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

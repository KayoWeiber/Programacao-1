using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex03;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta1 = new Conta(1, 1000);
            //conta_especial conta2 = new conta_especial(2, 1000, 100);

            //conta1.saque(1001);
            //conta1.saque(990);
            //conta1.verSaldo();

            //conta2.saque(1001);
            //conta2.verSaldo();
            //conta2.saque(50);
            //conta2.verSaldo();
            //conta2.saque(70);
            //conta2.verSaldo();
            //conta2.deposito(1200);
            //conta2.verSaldo();

            GerenciadorConta gerenciadorConta = new GerenciadorConta();
            int escolha;

            do 
            {
                Console.Write("\nMenu:\n1- Cadastrar conta\n2- Deposito\n3- Saque\n4- Ver saldo\n5- Sair\nDigite a escolha desejada: ");escolha= int.Parse(Console.ReadLine());
                switch(escolha) 
                {
                    case 1:
                        gerenciadorConta.cadastrarConta();
                        break;
                    case 2:
                        gerenciadorConta.deposito();
                        break;
                    case 3:
                        gerenciadorConta.saque();
                        break;
                    case 4:
                        gerenciadorConta.verSaldo();
                        break;
                    case 5:
                        Console.WriteLine("Programa finalizando...");
                        break;
                    default: 
                        Console.WriteLine("Por favor, digite um número válido! ");
                        break;
                }
            
            } while (escolha != 5);


        }
    }
}

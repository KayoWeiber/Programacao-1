using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex03;

namespace ex04
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
    internal class GerenciadorConta
    {
        Conta[] contas = new Conta[10];
        conta_especial[] contasEspeciais = new conta_especial[10];
        int countConta = 1;
        int countEspeciais = 1;

        public void cadastrarConta()
        {
            while (true)
            {
                Console.Write("\nQual tipo de conta deseja cadastrar?\n1- Conta sem limite\n2- Conta com limite especial\nDigite sua escolha: "); int cadasTipo = int.Parse(Console.ReadLine());
                if (cadasTipo < 1 || cadasTipo > 2)
                {
                    Console.WriteLine("Valor digitado não é válido.");
                }
                else
                {
                    switch (cadasTipo)
                    {
                        case 1:
                            if (countConta < 11)
                            {
                                Console.Write("\nDigite o saldo atual da conta: "); double saldoConta = double.Parse(Console.ReadLine());
                                contas[countConta] = new Conta(countConta, saldoConta);
                                Console.WriteLine($"Conta {countConta} cadastrada com sucesso!!");
                                countConta++;
                                
                            }
                            else { Console.WriteLine("Não é possível cadastrar conta, limite máximo de conta atingido!"); }

                            break;
                        case 2:
                            if (countEspeciais < 11)
                            {
                                Console.Write("\nDigite o saldo atual da conta: "); double saldoConta = double.Parse(Console.ReadLine());
                                Console.Write("\nDigite o limite atual da conta: "); double limiteConta = double.Parse(Console.ReadLine());
                                contasEspeciais[countEspeciais] = new conta_especial(countEspeciais, saldoConta, limiteConta);
                                Console.WriteLine($"Conta {countEspeciais} com limite cadastrada com sucesso!!");
                                countEspeciais++;
                                
                            }
                            else { Console.WriteLine("Não é possível cadastrar conta, limite máximo de contas atingido!"); }

                            break;
                    }
                    break;
                }
                

            }

        }
        public void deposito()
        {
            while (true) 
            {
                Console.Write("\nQual tipo de conta deseja realiza o Deposito:\n1- Conta sem limite\n2- Conta com limite\n digite a conta deseja: "); int tipoContaDeposito = int.Parse(Console.ReadLine());
                if (tipoContaDeposito<1 || tipoContaDeposito > 2)
                {
                    Console.WriteLine("Por favor digite um tipo de conta válido.");
                }
                else
                {
                    while (true) 
                    {
                        Console.WriteLine("Escolha o numero da conta que deseja realizar o depósito:"); contaCriadas(tipoContaDeposito);
                        Console.Write("Qual conta deseja realizar o depósito: "); int contaDeposito = int.Parse(Console.ReadLine());

                        switch (tipoContaDeposito)
                        {
                            case 1:
                                if (contas[contaDeposito]?.nro_conta != null)
                                {
                                    Console.Write("Digite o valor do depósito: "); double valorDeposito = double.Parse(Console.ReadLine());
                                    contas[contaDeposito].deposito(valorDeposito);
                                    

                                }
                                else
                                {
                                    Console.WriteLine("A Conta digitada não existe!");
                                }
                                break;
                            case 2:
                                if (contasEspeciais[contaDeposito]?.nro_conta != null)
                                {
                                    Console.Write("Digite o valor do depósito: "); double valorDeposito = double.Parse(Console.ReadLine());
                                    contasEspeciais[contaDeposito].deposito(valorDeposito);
                                    

                                }
                                else
                                {
                                    Console.WriteLine("A Conta digitada não existe!");
                                }
                                break;
                        }
                        break;

                    }

                    
                }
                break;
            }
        }
        public void saque()
        {
            while (true)
            {
                Console.Write("\nQual tipo de conta deseja realiza o saque:\n1- Conta sem limite\n2- Conta com limite\n digite a conta deseja: "); int tipoContaSaque = int.Parse(Console.ReadLine());
                if (tipoContaSaque < 1 || tipoContaSaque > 2)
                {
                    Console.WriteLine("Por favor digite um tipo de conta válido.");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Escolha o numero da conta que deseja realizar o saque:"); contaCriadas(tipoContaSaque);
                        Console.Write("Qual conta deseja realizar o saque: "); int ContaSaque = int.Parse(Console.ReadLine());

                        switch (tipoContaSaque)
                        {
                            case 1:
                                if (contas[ContaSaque]?.nro_conta != null)
                                {
                                    Console.Write("Digite o valor do saque: "); double valorSaque = double.Parse(Console.ReadLine());
                                    contas[ContaSaque].saque(valorSaque);
                                    

                                }
                                else
                                {
                                    Console.WriteLine("A Conta digitada não existe!");
                                }
                                break;
                            case 2:
                                if (contasEspeciais[ContaSaque]?.nro_conta != null)
                                {
                                    Console.Write("Digite o valor do saque: "); double valorSaque = double.Parse(Console.ReadLine());
                                    contasEspeciais[ContaSaque].saque(valorSaque);
                                    

                                }
                                else
                                {
                                    Console.WriteLine("A Conta digitada não existe!");
                                }
                                break;
                        }
                        break;

                    }


                }
                break;
            }

        }

        public void contaCriadas(int tipoConta) 
        {
            if (tipoConta ==1) 
            {
                for (int i = 0; i < contas.Length; i++)
                {
                    if (contas[i]?.nro_conta != null)
                    {
                        Console.WriteLine($"Conta Nº {contas[i].nro_conta}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < contasEspeciais.Length; i++)
                {
                    if (contasEspeciais[i]?.nro_conta != null)
                    {
                        Console.WriteLine($"Conta Nº {contasEspeciais[i].nro_conta}");
                    }
                }
            }
        }
        public void verSaldo()
        {
            while (true)
            {
                Console.Write("\nQual tipo de conta de deseja ver o Saldo:\n1- Conta sem limite\n2- Conta com limite\nDigite sua escolha: "); int tipoDConta = int.Parse(Console.ReadLine());
                if(tipoDConta <1 || tipoDConta > 2) 
                {
                    Console.WriteLine("Por favor, digite um tipo de conta válido!! ");

                }
                else
                {
                    Console.WriteLine("Qual conta deseja visualizar o saldo: "); contaCriadas(tipoDConta);
                    Console.Write("Digite o número da conta: "); int numeroConta = int.Parse(Console.ReadLine());

                    switch (tipoDConta)
                    {
                        case 1:
                            if (contas[numeroConta]?.nro_conta != null)
                            {
                                contas[numeroConta].verSaldo();
                            }
                            else
                            {
                                Console.WriteLine("A conta digitada não existe.");
                            }
                            break;
                        case 2:
                            if (contasEspeciais[numeroConta]?.nro_conta != null)
                            {
                                contasEspeciais[numeroConta].verSaldo();
                            }
                            else 
                            {
                                Console.WriteLine("A conta digitada não existe.");
                            }
                            break;
                    }
                   
                }
                break ;
            }
        }

    }
}

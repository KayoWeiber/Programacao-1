using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class conta_especial : Conta

    {
        public double saldoExtra { get; set; }
        double limite;
        public conta_especial(int nro_conta, double saldo, double saldoExtra) : base(nro_conta, saldo)
        {
            this.saldoExtra = saldoExtra;
            limite = saldoExtra;
        }
        public override void saque(double valorSaque)
        {
            if (valorSaque > (saldo+saldoExtra))
            {
                Console.WriteLine("Impossível realizar saque, saque maior que limite disponível!!");
            }
            else
            {
                if (valorSaque <= saldo)
                {
                    saldo -= valorSaque;
                    Console.WriteLine("Saque realizado com sucesso!");
                }
                else 
                {
                    double restantePagar = valorSaque - saldo;
                    saldo = 0;
                    saldoExtra -= restantePagar;

                    if (saldoExtra < 0)
                    {
                        Console.WriteLine("Impossível realizar saque, saque maior que limite disponível!!");
                        saldoExtra += restantePagar;
                    }
                    else
                    {
                        Console.WriteLine($"Saque realizado utilizando saldo especíal, saldo especíal atual: R${saldoExtra}");
                    }

                }
            }

        }
        public override void deposito(double valorDeposito)
        {
            double usadoDoLimite = limite - saldoExtra;

            if (usadoDoLimite > 0)
            {
                if (valorDeposito >= usadoDoLimite)
                {
                    saldoExtra += usadoDoLimite;
                    saldo += valorDeposito - usadoDoLimite;
                }
                else
                {
                    saldoExtra += valorDeposito;
                }
            }
            else
            {
                saldo += valorDeposito;
            }

            Console.WriteLine($"Depósito realizado. Saldo: R${saldo}, Limite disponível: R${saldoExtra}");
        }
        public override void verSaldo()
        {
            if (saldo != 0) 
            {
                base.verSaldo();
            }
            else { Console.WriteLine($"Saldo atual está no crédito especial, saldo extra disponível: R${saldoExtra} "); }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Conta
    {
        public int nro_conta {  get; set; }
        public double saldo { get; set; }

        public Conta(int nro_conta, double saldo)
        {
            this.nro_conta = nro_conta;
            this.saldo = saldo;
        }
        public virtual void deposito(double valorDeposito)
        {
            saldo = valorDeposito;
            Console.WriteLine("Deposito realizado com sucesso.");verSaldo();

            
        }
        public virtual void saque(double valorSaque)
        {
            if (saldo < 0)
            {
                Console.WriteLine("Impossível realizar saque, saldo menor que 0!!");
            }
            else
            {
                saldo -=valorSaque;
                if (saldo < 0)
                {
                    Console.WriteLine("Saldo insuficiente.");
                    saldo += valorSaque;
                }
                else
                {
                    Console.WriteLine("Saque Realizado com sucesso");
                }
            }
        }

        public virtual void verSaldo()
        {
            Console.WriteLine($"\nsaldo atual: R${saldo}");
        }
    }
}

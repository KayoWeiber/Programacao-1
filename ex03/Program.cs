using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1,1000);
            conta_especial conta2 = new conta_especial(2,1000,100);

            conta1.saque(1001);
            conta1.saque(990);
            conta1.verSaldo();

            conta2.saque(1001);
            conta2.verSaldo();
            conta2.saque(50);
            conta2.verSaldo();
            conta2.saque(70);
            conta2.verSaldo();
            conta2.deposito(1200);
            conta2.verSaldo();



        }
    }
}

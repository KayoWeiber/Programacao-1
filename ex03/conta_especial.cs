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
        public conta_especial(int nro_conta, double saldo, double saldoExtra) : base(nro_conta,saldo)
        {
            this.saldoExtra = saldoExtra;
        }
            
    }
}

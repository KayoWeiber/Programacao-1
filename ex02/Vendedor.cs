using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Vendedor : Gerente
    {
        public Vendedor(string nome, string setor, double salario, double bonus): base(nome,setor,salario,bonus) { }
    }
}

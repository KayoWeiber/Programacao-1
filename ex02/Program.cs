using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] funcionarios = new Funcionario[2];
            funcionarios[0] = new Gerente("Kayo","Envase",1930.00,1.3);
            funcionarios[1] = new Vendedor("John", "Venda", 2600, 1.1);

            funcionarios[0].Exibir();
            funcionarios[1].Exibir();
        }
    }
}

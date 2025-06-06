using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01andEx02
{
    internal class Vendedor:Funcionario
    {
        public double comissao {  get; set; }
        public Vendedor(string nome, int idade,double comissao):base(nome, idade) { this.comissao = comissao; }

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Vendedor com comissão de: {comissao}");
        }
    }
}

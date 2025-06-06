using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01andEx02
{
    internal class Gerente:Funcionario
    {
        public string departamento {  get; set; }
        public Gerente(string nome,int idade, string departamento):base(nome,idade) 
        {
            this.departamento = departamento;
        }
        public new void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Gerente do departamento: {departamento}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string setor { get; set; }
        //public double bonus {  get; set; }
        public double salario { get; set; }

        public Funcionario(string nome, string setor, double salario)
        {
            this.nome = nome;
            this.setor = setor;
            //this.bonus = bonus;
            this.salario = salario;
        }
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome}, setor: {setor}, Salario: R${salario}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___Ex09
{
    internal class Funcionario
    {
        private string nome { get; set; }
        private double salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public bool SalarioMedio()
        {
            return this.salario > 3000 ? true : false;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"~\nNome: {this.nome}, Salario: {salario}");
            bool media = this.SalarioMedio();
            if (media)
            {
                Console.WriteLine("Salario acima da media");
            }
            else
            {
                Console.WriteLine("Salario abaixo da media");
            }
        }
    }
}

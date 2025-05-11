using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_aula_08_05_2025
{
    internal class Funcionario
    {
        private string nome {  get; set; }
        private string cargo { get; set; }
        private double salario { get; set; }
        
        public Funcionario(string nome,string cargo, double salario) {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome:{nome}, Cargo: {cargo}, Salario: {salario}");
        }
    }
}

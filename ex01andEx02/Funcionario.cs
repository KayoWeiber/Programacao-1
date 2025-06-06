using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01andEx02
{
    internal class Funcionario
    {
        public string nome {  get; set; }
        public int idade { get; set; }
        public Funcionario(string nome, int idade) { this.nome = nome;this.idade = idade; }
        public virtual void Exibir()
        {
            Console.WriteLine($"\nNome: {nome}, Idade: {idade}");

        }
    }
}

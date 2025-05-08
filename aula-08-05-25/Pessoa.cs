using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08_05_25
{
    internal class Pessoa
    {
        private string nome { get; set; } //private set deixa a alteração privada *** deixar em public
        private int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_aula_05_06
{
    internal class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(string nome, double preco ) { this.nome = nome;this.preco = preco; }
        public override string ToString()
        {
            return $"Produto: {nome}, Preço: R${preco}";
        }
    }
}

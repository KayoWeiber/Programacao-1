using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_EX07
{
    internal class produto
    {
        private string nome {  get; set; }
        public double preco {  get; private set; }
        public int quantidade { get; private set; }

        public produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public void exibir() 
        {
            Console.WriteLine($"Nome: {nome}, Preço: {preco}, Quantidade: {quantidade}");
        }
        public void valorEstoque()
        {
            Console.WriteLine($"Valor total do produto {nome} é : R${preco * quantidade}");
        }
    }
}

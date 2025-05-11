using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05_aula_08_05
{
    internal class Produto
    {
        public string nome {  get; private set; }
        private double preco { get; set; }
        private int quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public void atualizarQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public void exibir()
        {
            Console.WriteLine($"Nome: {nome}, Preço: {preco}, Quantidade: {quantidade}");
        }
    }
}

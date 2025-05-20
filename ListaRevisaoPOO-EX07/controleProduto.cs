using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_EX07
{
    internal class controleProduto
    {
        private produto[] produtos = new produto[3];
        int count;

        public void cadastrarProduto()
        {
            if (count < 3)
            {
                Console.Write("Digite o nome do produto: "); string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: "); double preco = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade do produto: "); int quantidade = int.Parse(Console.ReadLine());
                produtos[count] = new produto(nome, preco, quantidade);
                Console.WriteLine("Cadastro Realizado");
                count++;
            }
            else Console.WriteLine("Não possui espaço.");
        }
        public void calcular()
        {
           
            for (int i = 0; i < produtos.Length; i++) 
            { produtos[i].valorEstoque(); }
            
        }
    }
}

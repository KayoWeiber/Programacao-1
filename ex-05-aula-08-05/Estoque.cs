using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05_aula_08_05
{
    internal class Estoque
    {
        private Produto[] produtos = new Produto[5];
        int count;
        public void adicionarProduto()
        {
            Console.Write("\nDigite o nome do produto: ");string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: "); double preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: "); int quantidade = int.Parse(Console.ReadLine());
            produtos[count] = new Produto(nome, preco, quantidade);
            Console.Write("Produto adicionado com sucesso!");
            count++;
        }
        public void listarProdutos()
        {
            Console.WriteLine("\nLista de produtos:");
            if (count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                produtos[i].exibir();
            }
        }
        public void atualizarProduto()
        {
            Console.Write("\nDigite o nome do produto que deseja atualizar: "); string nome = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (produtos[i].nome == nome)
                {
                    Console.Write("Digite a nova quantidade: "); int quantidade = int.Parse(Console.ReadLine());
                    produtos[i].atualizarQuantidade(quantidade);
                    Console.Write("Produto atualizado com sucesso!");
                    return;
                }
            }
            Console.Write("Produto não encontrado.");
        }

    }
}

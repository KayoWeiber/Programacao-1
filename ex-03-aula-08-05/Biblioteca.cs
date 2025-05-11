using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03_aula_08_05
{
    internal class Biblioteca
    {
        private Livro[] livros = new Livro[10];
        int count;
        public void AdicionarLivro()
        {
            if (count < 10)
            {
                Console.Write($"Digite o titulo do Livro: ");string modelo = Console.ReadLine();
                Console.Write($"Digite o autor do Livro: "); string autor = Console.ReadLine();
                Console.Write($"Digite o ano do Livro: "); int ano = int.Parse(Console.ReadLine());
                livros[count] = new Livro(modelo, autor, ano);
                Console.WriteLine("Livro adicionado com sucesso!");
                count++;
            }
            else
            {
                Console.WriteLine("Biblioteca cheia!");
            }
        }
        public void ListarLivros()
        {
            Console.WriteLine("Livros na biblioteca:");
            for (int i = 0; i < count; i++)
            {
                livros[i].Exibir();
            }
        }
        public void BuscarPorAutor()
        {
            Console.WriteLine($"Digite o nome do autor:"); string autor = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < count; i++)
            {
                if (livros[i].autor== autor)
                {
                    livros[i].Exibir();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Nenhum livro encontrado do autor informado.");
            }
        }

    }
}

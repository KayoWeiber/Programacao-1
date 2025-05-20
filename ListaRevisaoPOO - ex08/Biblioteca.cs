using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___ex08
{
    internal class Biblioteca
    {
        private Livro[] livros = new Livro[4];
        int count;

        public void Cadastrar()
        {
            if (count < 4)
            {
                Console.Write("Digite o título do livro: "); string titulo = Console.ReadLine();
                Console.Write("Digite o autor do livro: "); string autor = Console.ReadLine(); 
                livros[count] = new Livro(titulo, autor);
                Console.WriteLine("Livro cadastrado com sucesso!");
                count++;
            }
            else
            {
                Console.WriteLine("A biblioteca está cheia.");
            }
        }
        public void ExibirTodos()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Livro {i + 1}:");
                livros[i].Exibir();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___ex08
{
    internal class Livro
    {
        private string titulo { get; set; }
        private string autor { get; set; }

        public Livro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public void Exibir()
        {
            Console.WriteLine($"Título: {titulo}, Autor: {autor}");
        }
    }
}

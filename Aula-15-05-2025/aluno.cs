using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_05_2025
{
    internal class aluno
    {
        private string nome { get; set; }
        private int nota { get; set; }

        public aluno(string nome, int nota)
        {
            this.nome = nome;
            this.nota = nota;
        }
        public void exibir()
        {
            Console.WriteLine($"Nome: {nome}, Nota: {nota}");
        }
    }
}

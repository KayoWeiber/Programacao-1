using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace aula_08_05_25
{
    internal class Alunos
    {
        private string nome {  get; set; }
        private double nota { get; set; }

        public Alunos(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}, nota: {nota}");
        }
    }

}

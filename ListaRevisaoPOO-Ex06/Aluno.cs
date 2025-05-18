using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_Ex06
{
    internal class Aluno
    {
        private string nome { get; set; }
        private string cpf { get; set; }

        public Aluno(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}, CPF: {cpf}");
        }
    }
}

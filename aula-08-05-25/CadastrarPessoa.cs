using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula_08_05_25
{
    public class CadastrarPessoa
    {
        private Pessoa[] pessoas = new Pessoa[5];
        private int contador = 0;

        public void Cadastrar(string nome, int idade)
        {
            if(this.contador < pessoas.Length)
            {
                pessoas[contador] = new Pessoa (nome, idade);
                contador++;
            }
            else
            {
                Console.WriteLine($"\nNão foi possível inserir. Vetor lotado");
            }
            
        }
        public void Lista()
        {
            for (int i=0; i < contador; i++)
            {
                pessoas[i].Exibir();
            }
        }
    }
}

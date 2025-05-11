using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02_aula08_05
{
    internal class Veiculo
    {
        private string modelo { get; set; }
        private string marca { get; set; }
        private int ano { get; set; }

        public Veiculo(string modelo, string marca, int ano)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
        }
        public void Exibir()
        {
            Console.WriteLine($"Modelo: {modelo}, Marca: {marca}, Ano: {ano}");
        }


    }
}

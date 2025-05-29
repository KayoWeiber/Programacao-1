using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29_05
{
    internal class Program
    {
        public class veiculos
        {
            public string modelo { get; set; }
            public int ano { get; set; }

            public veiculos(string modelo, int ano)
            {
                this.modelo = modelo;
                this.ano = ano;
            }
            public void MostrarVeiculo()
            {
                Console.WriteLine($"Modelo: {modelo}, Ano de fabricação: {ano}");
            }
        }

        public class carro : veiculos 

        { 
            public int numeroPortas { get; set; }

            public carro(string modelo, int ano, int numeroPortas) : base(modelo,ano)
            {
                this.numeroPortas = numeroPortas;
            }

            public void exibirPortas()
            {
                MostrarVeiculo();
                Console.WriteLine($"Numeros de portas: {numeroPortas}");
            }
        }

        static void Main(string[] args)
        {
            carro veiculo1 = new carro("Fusca",1960,2);
            veiculo1.modelo = "Fusca";
           //veiculo1.ano = 1969;
            //veiculo1.numeroPortas = 2;
            //veiculo1.MostrarVeiculo();
            veiculo1.exibirPortas();
            veiculos veiculo2 = new veiculos("Uno",1990);
           
            veiculo2.MostrarVeiculo();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_07_05
{
    internal class Program
    {
        class estacionamento
        {
            public string placaVeiculo { get; set; }
            public string marcaVeiculo { get; set; }
            public string modeloVeiculo { get; set; }
            public string tipoVeiculo { get; set; }
            public int horasEntrada { get; set; }
            public int minutosEntrada { get; set; }
            public int horasSaida { get; set; }
            public int minutosSaida { get; set; }


            public estacionamento()
            {
                this.horasEntrada = -1;
                this.minutosEntrada = -1;
                this.horasSaida = -1;
                this.minutosSaida = -1;
            }

            //public void transformarHoras(int horasEntrada, int minutosEntrada,int horasSaida,int minutosSaida)
            //{
            //    this.horasEntrada = horasEntrada;
            //    this.minutosEntrada = minutosEntrada;
            //    this.horasSaida = horasSaida;
            //    this.minutosSaida = minutosSaida;

            //    if (minutosEntrada >=60)
            //    {
            //        Console.WriteLine($"A quantidade de minutos de entrada já se soma mais de 1 hora!");

            //    }else if (minutosSaida >= 60)
            //    {
            //        Console.WriteLine($"A quantidade de minutos de saida já se soma mais de 1 hora!");
            //    }
            //    int entradaTotal = (horasEntrada * 60) + minutosEntrada;
            //    int saidaTotal = (horasSaida * 60) + minutosSaida;
                
            //    if (entradaTotal < saidaTotal)
            //    {
            //        Console.WriteLine($"O horário de saída é menor que o de entrada!!");
            //    }

            //}
        }
        static void Main(string[] args)
        {
        }
    }
}

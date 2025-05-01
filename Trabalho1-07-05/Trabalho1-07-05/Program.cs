using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


            public estacionamento(string placaVeiculo,string marcaVeiculo,string modeloVeiculo, string tipoVeiculo,int horasEntrada,int minutosEntrada,int horasSaida,int minutosSaida)
            {
                this.placaVeiculo = placaVeiculo;
                this.marcaVeiculo = marcaVeiculo;
                this.modeloVeiculo = modeloVeiculo;
                this.tipoVeiculo = tipoVeiculo;
                this.horasEntrada = horasEntrada;
                this.minutosEntrada = minutosEntrada;
                this.horasSaida = horasSaida;
                this.minutosSaida = minutosSaida;
            }
            public void tempoTransformar()
            {
                this.horasEntrada = -1;
                this.minutosEntrada = -1;
                this.horasSaida = -1;
                this.minutosSaida = -1;
            }

            public void informacoesVeiculo()
            {
                Console.Write($"Digite a placa do veículo: ");
                this.placaVeiculo = Console.ReadLine();
                Console.Write($"Digite a marca do veículo: ");
                this.marcaVeiculo = Console.ReadLine();
                Console.Write($"Digite o modelo do veículo: ");
                this.modeloVeiculo = Console.ReadLine();
                int tipo = 0;

                while (true)
                {
                    try
                    {
                        Console.Write($"Tipos de veículo:\n1 - Passeio\n2 - Utilitário\n3 - Ônibus\n4 - Caminhão\nDigite a opção desejada:");
                        tipo = int.Parse(Console.ReadLine());
                        if (tipo < 1 || tipo > 4)
                        {
                            Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um número válido (apenas números).");
                    }
                }
                switch (tipo)
                {
                    case 1:
                        this.tipoVeiculo = "Passeio";
                        break;
                    case 2:
                        this.tipoVeiculo = "Utilitário";
                        break;
                    case 3:
                        this.tipoVeiculo = "Ônibus";
                        break;
                    case 4:
                        this.tipoVeiculo = "Caminhão";
                        break;
                }
            }
            public void informacoesEntrada()
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Digite a hora de entrada: ");
                        this.horasEntrada = int.Parse(Console.ReadLine());
                        if (this.horasEntrada < 0 || this.horasEntrada > 23)
                        {
                            Console.WriteLine("Hora inválida. Por favor, escolha um número entre 0 e 23.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um número válido (apenas números).");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write($"Digite os minutos de entrada: ");
                        this.minutosEntrada = int.Parse(Console.ReadLine());
                        if (this.minutosEntrada < 0 || this.minutosEntrada > 59)
                        {
                            Console.WriteLine("Minuto inválido. Por favor, escolha um número entre 0 e 59.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um número válido (apenas números).");
                    }

                }


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
            estacionamento veiculo = new estacionamento("", "", "", "", 0, 0, 0, 0);
            //veiculo.informacoesVeiculo();
            //Console.WriteLine(veiculo.tipoVeiculo);
            //veiculo.informacoesEntrada();
            //Console.WriteLine($"Hora de entrada: {veiculo.horasEntrada}:{veiculo.minutosEntrada}");
        }
    }
}

using System;
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
            public estacionamento(string placaVeiculo, string marcaVeiculo, string modeloVeiculo, string tipoVeiculo, int horasEntrada, int minutosEntrada, int horasSaida, int minutosSaida)
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
            public void tempoNegativar(){this.horasEntrada = -1; this.minutosEntrada = -1; this.horasSaida = -1; this.minutosSaida = -1;}
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
                    Console.Write($"Digite a hora de entrada: ");
                    this.horasEntrada = int.Parse(Console.ReadLine());
                    Console.Write($"Digite os minutos de entrada: ");
                    this.minutosEntrada = int.Parse(Console.ReadLine());
                    if (this.minutosEntrada < 0 || this.minutosEntrada > 59 || this.horasEntrada < 0 || this.horasEntrada > 23)
                    {
                        Console.WriteLine("Horário inválido. Por favor, escolha um horário válido.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            public void informacoesSaida()
            {
                while (true)
                {
                    Console.Write($"Digite a hora de saída: ");
                    this.horasSaida = int.Parse(Console.ReadLine());
                    Console.Write($"Digite os minutos de saída: ");
                    this.minutosSaida = int.Parse(Console.ReadLine());
                    if (this.horasSaida < 0 || this.horasSaida > 23 || this.minutosSaida < 0 || this.minutosSaida > 59)
                    {
                        Console.WriteLine("Horário inválido. Por favor, escolha um horário válido.");
                        continue;
                    }
                    else
                    {
                        if ((this.horasSaida < this.horasEntrada) || this.horasSaida == this.horasEntrada && this.minutosSaida < this.minutosEntrada)
                        {
                            Console.WriteLine($"A hora de saída não pode ser menor que a de entrada!");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }
            public int transformarHoras(){int entradaTotal = (horasEntrada * 60) + minutosEntrada;int saidaTotal = (horasSaida * 60) + minutosSaida;return saidaTotal - entradaTotal;}
            public void ValorEstacionamento()
            {
                int tempoTotal = transformarHoras();
                double valor = 0;
                double precoHora;
                switch (tipoVeiculo)
                {
                    case "Passeio":
                        precoHora = 3.50;
                        valor = Math.Ceiling(tempoTotal / 60.0) * precoHora;
                        break;
                    case "Utilitário":
                        precoHora = 4.50;
                        valor = Math.Ceiling(tempoTotal / 60.0) * precoHora;
                        break;
                    case "Ônibus":
                        precoHora = 7.50;
                        valor = Math.Ceiling(tempoTotal / 60.0) * precoHora;
                        break;
                    case "Caminhão":
                        precoHora = 10.00;
                        valor = Math.Ceiling(tempoTotal / 60.0) * precoHora;
                        break;
                }
                Console.WriteLine($"O valor total do estacionamento é: R$ {valor:F2}");
            }
        }
        static void Main(string[] args)
        {
            estacionamento veiculo = new estacionamento("", "", "", "", 0, 0, 0, 0);
            estacionamento[] vagas = new estacionamento[10];
            for (int i = 0; i < vagas.Length; i++)
            {
                vagas[i] = new estacionamento("", "", "", "", -1, -1, -1, -1);
            }
            while (true)
            {
                Console.Write("Menu:\n1. Entrada de veículos\n2. Saída de veículo\n3. Sair\nDigite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao < 1 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 3.");
                }
                else
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\nEntrada de veículos\nVagas disponíveis:");
                            bool algumaDisponivel = false;
                            for (int i = 0; i < vagas.Length; i++)
                            {
                                if (vagas[i].horasEntrada == -1)
                                {
                                    Console.WriteLine($"Vaga {i} - (disponível)");
                                    algumaDisponivel = true;
                                }
                            }
                            if (!algumaDisponivel)
                            {
                                Console.WriteLine("Nenhuma vaga disponível no momento.");
                            }
                            else
                            {
                                Console.Write("Escolha uma vaga disponível (digite o número):");
                                int vagaEscolhida = int.Parse(Console.ReadLine());
                                if (vagaEscolhida < 0 || vagaEscolhida >= vagas.Length)
                                {
                                    Console.WriteLine("Vaga inválida. Por favor, escolha um número entre 0 e 9.");
                                    continue;
                                }
                                else
                                {
                                    if (vagas[vagaEscolhida].horasEntrada != -1)
                                    {
                                        Console.WriteLine("Essa vaga já está ocupada.");
                                        continue;
                                    }
                                    else
                                    {
                                        estacionamento novoVeiculo = new estacionamento("", "", "", "", 0, 0, 0, 0);
                                        novoVeiculo.informacoesVeiculo();
                                        novoVeiculo.informacoesEntrada();
                                        vagas[vagaEscolhida] = novoVeiculo;
                                        Console.WriteLine($"\nVeículo {veiculo.placaVeiculo} estacionado na vaga {vagaEscolhida}.");
                                    }
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nSaída de veículo\n\"Vagas ocupadas: \"");
                            bool algumaOcupada = false;
                            for (int i = 0; i < vagas.Length; i++)
                            {
                                if (vagas[i].horasEntrada != -1)
                                {
                                    Console.WriteLine($"- Vaga {i}");
                                    algumaOcupada = true;
                                }
                            }
                            if (!algumaOcupada)
                            {
                                Console.WriteLine("Nenhuma vaga ocupada no momento.");
                            }
                            else
                            {
                                Console.Write("Escolha uma vaga ocupada (digite o número):");
                                int vagaEscolhida = int.Parse(Console.ReadLine());
                                if (vagaEscolhida < 0 || vagaEscolhida >= vagas.Length)
                                {
                                    Console.WriteLine("Vaga inválida. Por favor, escolha um número entre 0 e 9.");
                                    continue;
                                }
                                else
                                {
                                    if (vagas[vagaEscolhida].horasEntrada == -1)
                                    {
                                        Console.WriteLine("Essa vaga não está ocupada.");
                                        continue;
                                    }
                                    else
                                    {
                                        vagas[vagaEscolhida].informacoesSaida();
                                        vagas[vagaEscolhida].ValorEstacionamento();
                                        vagas[vagaEscolhida].tempoNegativar();
                                        Console.WriteLine($"\nVeículo {veiculo.placaVeiculo} saiu da vaga {vagaEscolhida}.");
                                    }
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Sistema encerrado.");
                            return;
                    }
                }
            }
        }
    }
}
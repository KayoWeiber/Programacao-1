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
            public estacionamento(string p, string m, string mo, string t, int he, int me, int hs, int ms)
            { placaVeiculo = p; marcaVeiculo = m; modeloVeiculo = mo; tipoVeiculo = t; horasEntrada = he; minutosEntrada = me; horasSaida = hs; minutosSaida = ms; }
            public void tempoNegativar() { horasEntrada = minutosEntrada = horasSaida = minutosSaida = -1; }
            public void informacoesVeiculo()
            {
                Console.Write("Digite a placa do veículo: "); placaVeiculo = Console.ReadLine();
                Console.Write("Digite a marca do veículo: "); marcaVeiculo = Console.ReadLine();
                Console.Write("Digite o modelo do veículo: "); modeloVeiculo = Console.ReadLine();
                int tipo; while (true)
                {
                    Console.Write("Tipos de veículo:\n1 - Passeio\n2 - Utilitário\n3 - Ônibus\n4 - Caminhão\nDigite a opção desejada:");
                    tipo = int.Parse(Console.ReadLine());
                    if (tipo >= 1 && tipo <= 4) break; else Console.WriteLine("Opção inválida. Escolha entre 1 e 4.");
                }
                tipoVeiculo = tipo == 1 ? "Passeio" : tipo == 2 ? "Utilitário" : tipo == 3 ? "Ônibus" : "Caminhão";
            }
            public void informacoesEntrada()
            {
                while (true)
                {
                    Console.Write("Digite a hora de entrada: "); horasEntrada = int.Parse(Console.ReadLine());
                    Console.Write("Digite os minutos de entrada: "); minutosEntrada = int.Parse(Console.ReadLine());
                    if (minutosEntrada >= 0 && minutosEntrada <= 59 && horasEntrada >= 0 && horasEntrada <= 23) break;
                    Console.WriteLine("Horário inválido.");
                }
            }
            public void informacoesSaida()
            {
                while (true)
                {
                    Console.Write("Digite a hora de saída: "); horasSaida = int.Parse(Console.ReadLine());
                    Console.Write("Digite os minutos de saída: "); minutosSaida = int.Parse(Console.ReadLine());
                    if (horasSaida < 0 || horasSaida > 23 || minutosSaida < 0 || minutosSaida > 59)
                    { Console.WriteLine("Horário inválido."); continue; }
                    if (horasSaida < horasEntrada || (horasSaida == horasEntrada && minutosSaida < minutosEntrada))
                    { Console.WriteLine("A hora de saída não pode ser menor que a de entrada!"); continue; }
                    break;
                }
            }
            public int transformarHoras() => (horasSaida * 60 + minutosSaida) - (horasEntrada * 60 + minutosEntrada);
            public void ValorEstacionamento()
            {
                int tempo = transformarHoras(); double valor = 0, precoHora = tipoVeiculo == "Passeio" ? 3.5 : tipoVeiculo == "Utilitário" ? 4.5 : tipoVeiculo == "Ônibus" ? 7.5 : 10.0;
                valor = Math.Ceiling(tempo / 60.0) * precoHora;
                Console.WriteLine($"O valor total do estacionamento é: R$ {valor:F2}");
            }
        }
        static void Main(string[] args)
        {
            estacionamento[] vagas = new estacionamento[10];
            for (int i = 0; i < vagas.Length; i++) vagas[i] = new estacionamento("", "", "", "", -1, -1, -1, -1);
            while (true)
            {
                Console.Write("Menu:\n1. Entrada de veículos\n2. Saída de veículo\n3. Sair\nDigite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("\nEntrada de veículos\nVagas disponíveis (digite o numero):"); bool disponivel = false;
                    for (int i = 0; i < vagas.Length; i++) if (vagas[i].horasEntrada == -1) { Console.WriteLine($"Vaga {i} - (disponível)"); disponivel = true; }
                    if (!disponivel) Console.WriteLine("Nenhuma vaga disponível.");
                    else
                    {
                        Console.Write("Escolha uma vaga: "); int v = int.Parse(Console.ReadLine());
                        if (v < 0 || v >= vagas.Length || vagas[v].horasEntrada != -1) { Console.WriteLine("Vaga inválida ou ocupada."); continue; }
                        estacionamento novo = new estacionamento("", "", "", "", 0, 0, 0, 0);
                        novo.informacoesVeiculo(); novo.informacoesEntrada(); vagas[v] = novo;
                        Console.WriteLine($"\nVeículo {novo.placaVeiculo} estacionado na vaga {v}.");
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nSaída de veículo\nVagas ocupadas (digite o numero):"); bool ocupada = false;
                    for (int i = 0; i < vagas.Length; i++) if (vagas[i].horasEntrada != -1) { Console.WriteLine($"- Vaga {i}"); ocupada = true; }
                    if (!ocupada) Console.WriteLine("Nenhuma vaga ocupada.");
                    else
                    {
                        Console.Write("Escolha uma vaga: "); int v = int.Parse(Console.ReadLine());
                        if (v < 0 || v >= vagas.Length || vagas[v].horasEntrada == -1) { Console.WriteLine("Vaga inválida ou desocupada."); continue; }
                        vagas[v].informacoesSaida(); vagas[v].ValorEstacionamento(); vagas[v].tempoNegativar();
                        Console.WriteLine($"\nVeículo {vagas[v].placaVeiculo} saiu da vaga {v}.");
                    }
                }
                else if (opcao == 3) { Console.WriteLine("Sistema encerrado."); return; }
                else Console.WriteLine("Opção inválida.");
            }
        }
    }
}

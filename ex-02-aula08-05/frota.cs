using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02_aula08_05
{
    internal class frota
    {
        private Veiculo[] veiculos = new Veiculo[5];
        int count;

        public void CadastrarVeiculo()
        {
            if (count < 5)
            {
                Console.Write("Digite o modelo do veículo:"); string modelo = Console.ReadLine();
                Console.Write("Digite a marca do veículo:"); string marca = Console.ReadLine();
                Console.Write("Digite o ano do veículo:"); int ano = int.Parse(Console.ReadLine());
                veiculos[count] = new Veiculo(modelo, marca, ano);
                Console.WriteLine("Veículo cadastrado com sucesso!");
                count++;
            }
            else
            {
                Console.WriteLine("Limite de veículos atingido.");
            }
        }
        public void ListarVeiculos()
        {
            if (count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    veiculos[i].Exibir();
                }
            }
        }
    }
}

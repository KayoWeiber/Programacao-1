using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO___Ex09
{
    internal class ControleFuncionario
    {
        private Funcionario[] funcionarios = new Funcionario[5];
        int count;

        public void AdicionarFuncionario()
        {
            if (count < funcionarios.Length)
            {
                Console.Write("Digite o nome do funcionario:");string nome = Console.ReadLine();
                Console.Write("Digite o salario do funcionario:"); double salario = double.Parse(Console.ReadLine());
                funcionarios[count] = new Funcionario(nome, salario);
                Console.WriteLine("Funcionario adicionado com sucesso");
                count++;
            }
            else
            {
                Console.WriteLine("Limite de funcionarios atingido");
            }
        }   
        public void ExibirFuncionarios()
        {
            for (int i = 0; i < count; i++)
            {
                funcionarios[i].ExibirDados();
            }
        }
    }
}

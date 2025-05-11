using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_aula_08_05_2025
{
    internal class GerenciadorFuncionario
    {
        private Funcionario[] funcionarios = new Funcionario[10];
        int count;
        public void cadastrarFuncionario()
        {
            if (count > funcionarios.Length)
            {
                Console.Write("Digite o nome do funcionario: ");string nome=Console.ReadLine();
                Console.Write("Digite o cargo do funcionario: ");string cargo=Console.ReadLine();
                Console.Write("Digite o salario do funcionario: "); double salario = double.Parse(Console.ReadLine());
                //funcionarios[count] = new Funcionario[nome, cargo, salario];

            }
        }
    }
}

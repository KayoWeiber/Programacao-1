using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_05_2025
{
    internal class turma
    {
        private aluno[] alunos = new aluno[3];
        int count;
        public void cadastrar()
        {
            if (count < 3)
            {
                Console.Write("Digite o nome do aluno:"); string nome = Console.ReadLine();
                Console.Write("Digite a nota do aluno:"); int nota = int.Parse(Console.ReadLine());
                alunos[count] = new aluno(nome, nota);
                count++;
            }
            else
            {
                Console.WriteLine("Turma cheia!");
            }
        }
        public void listar()
        {
            for (int i = 0; i < count; i++)
            {
                alunos[i].exibir();
            }
        }
    }
}

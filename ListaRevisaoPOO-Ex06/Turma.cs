using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRevisaoPOO_Ex06
{
    internal class Turma
    {
        private Aluno[] alunos= new Aluno[3]; //classe turma interliga com classe aluno
        int count;

        public void Cadastrar()
        {
            if (count < 3)
            {
                Console.Write("Digite o nome do aluno:"); string nome = Console.ReadLine();
                Console.Write("Digite o CPF do aluno:"); string cpf = Console.ReadLine();
                alunos[count] = new Aluno(nome, cpf);
                count++;
            }
            else { Console.WriteLine("Limite de alunos atingido."); }
        }
        public void Listar()
        {
            if (count == 0) Console.WriteLine("Nenhum aluno cadastrado.");
                for (int i = 0; i < count; i++)
                {
                    alunos[i].Exibir();
                }
        }
    }
}

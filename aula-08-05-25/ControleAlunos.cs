using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08_05_25
{
    public class ControleAlunos
    {
        private Alunos[] aluno = new Alunos[4];
        int count;

        public void Cadastrar(string nome, double nota)
        {
            if (this.count < aluno.Length) {
                aluno[count]=new Alunos(nome,nota);
                count++;
            }
            else
            {
                Console.WriteLine($"\nNão foi possível inserir. Vetor lotado");
            }
        }
        public void ExibirTodos()
        {
            for (int i = 0; i < count; i++)
            {
                aluno[i].Exibir();
            }
        }
    }
}

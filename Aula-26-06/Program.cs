using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26_06
{
    internal class Program
    {
        public abstract class funcionario
        {
            public string matricula { get; set; }
            public string nome { get; set; }

            public void mostrar_funcionario()
            {
                Console.WriteLine($"Matricula {0} - Nome {1}",this.matricula,this.nome);
            }
            public abstract double comissao();

        }
        public class vendedor : funcionario
        {
            public override double comissao()
            {
                return Double.Parse("0,1");
            }
        }
        public class atendente : funcionario
        {
            public override double comissao()
            {
                return Double.Parse("0,05");
            }
        }
        public class Gerente : funcionario
        {
            public override double comissao()
            {
                return Double.Parse("0,2");
            }
        }
        static void Main(string[] args)
        {
            vendedor joao=new vendedor();
            Gerente Kayo=new Gerente();
            atendente Murilo =new atendente();

            Console.WriteLine("Comissão do Kayo {0}%",Kayo.comissao()*100);
            Console.WriteLine("Comissão do Joao {0}%", joao.comissao()*100);
            Console.WriteLine("Comissão do Murilo {0}%", Murilo.comissao() * 100);
        }
    }
}

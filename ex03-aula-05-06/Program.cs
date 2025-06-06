using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Overload é a quando há dois ou mais métodos com o mesmo nome na mesma classe, mas com parâmetros diferentes (quantidade, tipos ou ordem).
//Isso permite que um mesmo método seja chamado de maneiras diferentes, de acordo com a necessidade.
//Já Override é a alteração é maneira de alterar um método herdado.
namespace ex01andEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Kayo", 20);
            Gerente gerente = new Gerente("Kayo2",20,"Envase");
            Vendedor vendedor = new Vendedor("Kayo3", 20, 3.5);

            funcionario.Exibir();
            gerente.Exibir();
            vendedor.Exibir();
        }
    }
}

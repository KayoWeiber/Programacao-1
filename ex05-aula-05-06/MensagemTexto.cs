using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_aula_05_06
{
    internal class MensagemTexto :Mensagem
    {

        public  void Enviar(int numero,string mensagem)
        {
            Console.WriteLine($"Mensagem de texto enviada para {numero}: {mensagem}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_aula_05_06
{
    internal class MensagemEmail:Mensagem
    {
        public void Enviar(string email, string conteudo) 
        {
            Console.WriteLine($"E-mail enviado para {email}:{conteudo}");
        
        }
    }
}

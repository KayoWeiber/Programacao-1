using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_aula_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MensagemEmail msgEmail = new MensagemEmail();
            MensagemTexto msgTexto = new MensagemTexto();
            int opcao;
            do {
                Console.Write("\n----MENU----\n1- Enviar Mensagem de Texto\n2- Enviar E-mail\n3 - Sair\nDigite a opção desejada: "); opcao=int.Parse(Console.ReadLine());
                switch (opcao) 
                {
                    case 1:
                        int numero;
                        Console.Write("Digite o número de telefone para enviar mensagem: ");string num=Console.ReadLine();
                        bool conversao = int.TryParse(num, out numero);
                        if (conversao)
                        {
                            Console.Write("Digite a mensagem desejada: ");string mensagem=Console.ReadLine();
                            msgTexto.Enviar(numero, mensagem);
                        }
                        else { Console.WriteLine("Por favor, digite um número válido."); }
                            break;
                
                }
            
            
            } while (opcao != 3);
        }
    }
}

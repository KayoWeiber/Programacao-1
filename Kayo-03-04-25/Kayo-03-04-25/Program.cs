using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kayo_03_04_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hello World!!");
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" Olá Kayo!!");
            Console.ResetColor();
            Console.WriteLine("Teste Realizado");
            
            int idade;
            idade = 20;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(idade);   

            bool ativo = false;
            Console.WriteLine(ativo);

            string nome = "";

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.WriteLine("Escreva sua idade:");
            idade = int.Parse(Console.ReadLine());
            idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Kayo {1} {0} ", idade, nome);
            
            int Num1 = 9;
            int Num2 = 10;

            Console.WriteLine(Num1 < Num2 ? "Num1 Menor" : "Num2 Menor");
            
            int count=0;
            //for (count = 0; count < 10; count++) {
            //Console.WriteLine(count);
            //}
            //Console.WriteLine(count);

            //while (count < 0)
            //{
            //    Console.WriteLine("Qual valor de count?");
            //    count=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Saiu");

            do
            {
                Console.WriteLine("Qual valor de count?");
                count = int.Parse(Console.ReadLine());
            } while (count < 0);
            Console.WriteLine("Saiu");
        }
    }
}

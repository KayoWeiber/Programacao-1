using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_05_06
{
    internal class Program
    {
        public class Calculadora
        {
           public int Somar(int a, int b)
            {
                return a + b;
            }
            public double Somar(double x, double y) {
                return x + y;
            }
            public int Somar(int a, int b, int c) {
                return a + b + c;
            }
            public int Somar()
            {
                Console.Write("Informe a: "); int a= int.Parse(Console.ReadLine());
                Console.Write("Informe b:"); int b= int.Parse(Console.ReadLine());
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Console.WriteLine(cal.Somar(1, 2));
            Console.WriteLine(cal.Somar(1.1, 2.1));
            Console.WriteLine(cal.Somar(1,2,3));
            Console.WriteLine(cal.Somar());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26_06_Interface
{
    internal class Program
    {
        interface IVoador
        {
            void Voar();
            void comer();
        }
        interface INadador
        {
            int distancia { get; set; }
            void Nadar();
            void comer();
        }
        public class passaro : IVoador
        {
            public void comer()
            {
                Console.WriteLine("comendo");
            }

            public void Voar()
            {
                Console.WriteLine("Voando");
            }
        }
        public class pinguin : INadador
        {
            public int distancia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void comer()
            {
                Console.WriteLine("comendo");
            }

            public void Nadar()
            {
                Console.WriteLine($"nadando");
            }
        }
        public class pato : INadador, IVoador
        {
            public int distancia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void comer()
            {
                Console.WriteLine("comendo");
            }

            public void Nadar()
            {
                Console.WriteLine($"nadando");
            }

            public void Voar()
            {
                Console.WriteLine("Voando");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

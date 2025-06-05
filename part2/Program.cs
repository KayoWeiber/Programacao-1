using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        public sealed class utilitario // não deixar herdar
        {
            public int a {  get; set; }

            public void Exibir()
            {
                Console.WriteLine("função");
            }
            public override string ToString()
            {
                return "O numero é "+ Convert.ToString(a+2);
            }
        }

        public class Animal
        {
            public void Emitir()
            {
                Console.WriteLine("Animal está emitindo som!");
            }
        }
        public class  gato:Animal
        {
            public new void Emitir() { Console.WriteLine("Miau"); }
        }
        public class cachorro : Animal
        {
            public new void Emitir() { Console.WriteLine("au au"); }
        }

        //public class teste:utilitario { } // não funciona
        static void Main(string[] args)
        {
            string numero;
            utilitario util = new utilitario();
            util.Exibir();
            util.a = 10;
            numero = util.ToString();
            Console.WriteLine(numero);

            Animal animal = new Animal();
            gato animal2 = new gato();
            cachorro animal3 = new cachorro();

            animal.Emitir();
            animal2.Emitir();
            animal3.Emitir();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];

            animais[0] = new Animal();
            animais[1] = new cachorro();
            animais[2] = new gato();

            animais[0].emitirSom();
            animais[1].emitirSom();
            animais[2].emitirSom();
        }
    }
}

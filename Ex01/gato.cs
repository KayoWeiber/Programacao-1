using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class gato:Animal
    {
        public override void emitirSom()
        {
            base.emitirSom();
            Console.WriteLine("gato está fazendo barulho");
        }
    }
}

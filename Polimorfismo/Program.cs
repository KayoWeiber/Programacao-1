using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        public class veiculo
        {
            public virtual void mover()
            {
                Console.WriteLine("O veiculo está se movendo");
            }
        }
        public class Carro : veiculo 
        {
            public override void mover() 
            {
                Console.WriteLine("O carro está se movendo");
            }
        }
        public class Moto : veiculo 
        {
            public override void mover() {
                Console.WriteLine("Moto está se movendo.");
                base.mover();
            
            }
        
        }
        static void Main(string[] args)
        {
            veiculo veiculos = new veiculo();
            Carro carro = new Carro();
            Moto moto = new Moto();
            carro.mover();
            veiculos.mover();
            moto.mover();
            veiculo[] veiculosVetor = new veiculo[3];
            veiculosVetor[0] = new veiculo();
            veiculosVetor [1] = new Carro();
            veiculosVetor [2] = new Moto();

        }
    }
}

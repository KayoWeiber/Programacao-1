using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Abstract
{
    internal class Program
    {   
        public abstract class FormaGeometrica
        {
            public abstract double area();
            public abstract double perimetro();
        }
        public class TrianguloRetangulo : FormaGeometrica
        {
            private double Base {get; set;}
            private double Altura {get; set;}
            private double Hipotenusa;

            public TrianguloRetangulo(double Base,double Altura)
            {
                this.Base = Base;
                this.Altura = Altura;
                this.Hipotenusa = CalcularHipotenusa();
            }

            public double CalcularHipotenusa()
            {
                return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            }

            public override double area()
            {
                return this.Base * this.Altura / 2;
            }

            public override double perimetro()
            {
                return Base + Altura + Hipotenusa;
            }
        }
        public class Circulo : FormaGeometrica
        {
            private double Raio {get; set;}

            public Circulo(double Raio)
            {
                this.Raio = Raio;
            }

            public override double area()
            {
                return Math.PI * (Raio*Raio); // Math.Pow é para ao quadrado
            }

            public override double perimetro()
            {
                throw new NotImplementedException();
            }
        }
        public class Retangulo : FormaGeometrica
        {
            public override double area()
            {
                throw new NotImplementedException();
            }

            public override double perimetro()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

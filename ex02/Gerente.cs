using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Gerente : Funcionario
    {
        private double bonus {  get; set; }
        public Gerente(string nome, string setor, double salario,double bonus) : base(nome, setor, salario)
        {
            this.bonus = bonus;

        }
        public virtual double calcularBonus()
        {
            return salario * bonus;
        }
        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Salario com bonus: R${calcularBonus()}");
        }
    }
}

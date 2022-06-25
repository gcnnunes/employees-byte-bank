using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao() // override permite que esse metodo sobrescreva o metodo da classe que ele é herdado
        {
            return Salario * 0.17;
        }
    }
}

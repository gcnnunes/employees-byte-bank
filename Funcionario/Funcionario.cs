using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // impede que essa classe seja instanciada, uma vez que não deveriamos ter uma pessoa "funcionario", isso é apenas uma abstração
        
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Registering EMPLOYEE...");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario(); // virtual permite que esse metodo seja sobrescrito por outro metodo que herde de Funcionario

        public abstract double GetBonificacao();
    }
}

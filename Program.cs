using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao(); 

            Console.ReadLine(); 
        }

        public static void CalcularBonificacao() // uma classe estática não pode ser instanciada. A vantagem de usar uma classe estática é que o compilador pode verificar se nenhum membro de instância foi adicionado acidentalmente
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20"); 
            guilherme.Nome = "Guilherme";

            camila.AumentarSalario();
            guilherme.AumentarSalario();
            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total of bonus this month:" +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
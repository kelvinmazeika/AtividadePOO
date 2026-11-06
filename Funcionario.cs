using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public int Salario { get; private set; }

        public void AumentarSalario(double percentual)
        {
            double novoSalario = Salario * (percentual / 100 + 1);
            Console.WriteLine($"O Salário atual é de R$ {novoSalario}");
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O Salário atual é de R$ {Salario}");
        }
    }
}
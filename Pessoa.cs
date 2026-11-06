using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Cidade { get; set; }
        public int Idade { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($" {Nome} - {Idade} - {Cidade}");
        }
    }
}
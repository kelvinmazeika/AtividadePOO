using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Calculadora
    {
        public void Somar(decimal a, decimal b)
        {
            decimal resultado = a + b;
            Console.WriteLine($"O Resultado é: {resultado}");
        }

        public void Subtrair(decimal a, decimal b)
        {
            decimal resultado = a - b;
            Console.WriteLine($"O Resultado é: {resultado}");
        }

        public void Multiplicar(decimal a, decimal b)
        {
            decimal resultado = a * b;
            Console.WriteLine($"O Resultado é: {resultado}");
        }

        public static void Dividir(decimal a, decimal b)
        {
            if(b > 0)
            {
            decimal resultado = a / b;
            Console.WriteLine($"O Resultado é: {resultado}");
            } else
            Console.WriteLine($"Divisor não pode ser 0");
        }
    }
}
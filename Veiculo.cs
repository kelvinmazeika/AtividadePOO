using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Veiculo
    {
        public int Velocidade { get; private set;}

        public void AlterarVelocidade(int velocidade)
        {
            if(velocidade > 0 && velocidade <= 200)
            {
                Velocidade = velocidade;
                Console.WriteLine($"Velocidade alterada para {velocidade}Km/h.");
            } else 
            Console.WriteLine($"Número fora dos parâmetros.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadePOO;

namespace AtividadePOO
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "A vida de Manoel Gomes";
            Autor = "Manoel Gomes";
            NumeroPaginas = 25;
        }

        public Livro(string titulo)
        {
            Titulo = titulo;
            Autor = "Manoel Gomes";
            NumeroPaginas = 25;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = 25;
        }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public void ExibirDadosLivro()
        {
            Console.WriteLine($" {Titulo} - {Autor} - {NumeroPaginas}");
        }
    }
}
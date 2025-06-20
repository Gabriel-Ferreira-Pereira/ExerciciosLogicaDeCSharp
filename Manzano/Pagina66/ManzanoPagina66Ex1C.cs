using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A Soma dos Cem Primeiros Números");

            int soma = 0;

            for (int num = 1; num < 101; num++)
            {
                soma += num;
            }
            Console.WriteLine($"A soma é: {soma}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trigos no Xadrez");

            ulong totaisGraos = 0;
            ulong quantidadeGraos = 1;

            for(int quadros = 1; quadros < 65; quadros++)
            {
                totaisGraos += quantidadeGraos;
                quantidadeGraos *= 2;
            }

            Console.WriteLine($"A soma de tudo deu: {totaisGraos}");
        }
    }
}

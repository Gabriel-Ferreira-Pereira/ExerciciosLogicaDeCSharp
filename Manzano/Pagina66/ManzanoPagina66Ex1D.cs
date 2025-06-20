using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos Pares de 1 a 500");

            int soma = 0;

            for(int num = 1; num < 501; num++)
            {
                if(num % 2 == 0)
                {
                    soma += num;
                }
            }
            Console.WriteLine($"A soma é: {soma}");
        }
    }
}

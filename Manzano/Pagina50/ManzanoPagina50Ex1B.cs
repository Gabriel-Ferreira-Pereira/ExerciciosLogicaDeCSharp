using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório dos Pares de 1 a 500");

            int contador = 1;
            int pares = 0;

            do
            {
                if (contador % 2 == 0)
                {
                    pares += contador;
                }
                contador++;
            }while(contador < 501);

            Console.WriteLine($"A somatória é: {pares}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadrados Inteiros do 15 a 200");

            for(int num = 15; num < 201; num++)
            {
                double quadrado = Math.Pow(num, 2);

                Console.WriteLine($"{num} ^ 2 = {quadrado}");
            }
        }
    }
}

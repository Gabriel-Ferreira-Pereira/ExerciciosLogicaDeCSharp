using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1G
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Potência de 3");

            int potencia = 1;

            for(int expoente = 0;  expoente < 16; expoente++)
            {
                Console.WriteLine($"3 ^ {expoente} = {potencia}");

                potencia *= 3;
            }
        }
    }
}

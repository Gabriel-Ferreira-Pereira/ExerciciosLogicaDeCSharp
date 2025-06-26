using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1K
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fatoriais Ímpares do 1 ao 10");

            for(int numero = 1; numero < 11; numero += 2)
            {
                int fatorial = 1;

                for(int contador = 1; contador <= numero; contador++)
                {
                    fatorial *= contador;
                }
                Console.WriteLine($"{numero} = {fatorial}");
            }
        }
    }
}

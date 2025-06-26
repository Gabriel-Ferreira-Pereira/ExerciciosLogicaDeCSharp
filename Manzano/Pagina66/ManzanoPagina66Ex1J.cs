using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1J
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Celsius para Fahrenheit");

            for (int celsius = 10; celsius < 101; celsius += 10)
            {
                int fahrenheit = (9 * celsius + 160) / 5;

                Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
            }
        }
    }
}

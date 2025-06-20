using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1F
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Divisiveis por 4");

            for(int num = 1; num < 201; num++)
            {
                if(num % 4 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

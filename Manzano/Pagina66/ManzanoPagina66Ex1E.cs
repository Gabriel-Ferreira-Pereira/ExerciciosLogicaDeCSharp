using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1E
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ímpares do 1 ao 20");

            for(int num = 0; num < 21; num++)
            {
                if(num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

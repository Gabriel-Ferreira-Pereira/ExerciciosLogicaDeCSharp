using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números Divisiveis por 4 entre 1 a 200");

            int contador = 1;

            do
            {
                if (contador % 4 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }while(contador < 201);
        }
    }
}

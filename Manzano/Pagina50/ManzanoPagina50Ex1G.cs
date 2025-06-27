using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1G
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fatorial dos Números Ímpares de 1 a 10");

            int numero = 1;
            int fatorial;
            int contador;

            do
            {
                if (numero % 2 != 0)
                {
                    fatorial = 1;
                    contador = 1;

                    do
                    {
                        fatorial *= contador;
                        contador++;
                    }while(contador <= numero);

                    Console.WriteLine($"{numero}! = {fatorial}");
                }

                numero++;
            }while(numero < 11);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadrados de 15 a 200");

            int contador = 15;
            int elevacao;

            do
            {
                elevacao = contador * contador;

                Console.WriteLine($"{contador} ^ 2 = {elevacao}");

                contador++;
            }while(contador < 201);
        }
    }
}

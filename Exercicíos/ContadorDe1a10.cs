using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class ContadorDe1a10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contador de 1 a 10");

            int contador = 1;

            while(contador < 11)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
    }
}

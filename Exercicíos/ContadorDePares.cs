using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class ContadorDePares
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contador de Pares");

            int numero = 1;

            while(numero < 21)
            {
                if(numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
        }
    }
}

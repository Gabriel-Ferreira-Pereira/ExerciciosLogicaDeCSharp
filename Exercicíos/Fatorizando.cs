using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class Fatorizando
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fatorizando");

            int fatorial = 1;

            Console.WriteLine("Digite um número: ");

            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            int numero = numeroDigitado;

            while(numero > 0)
            {
                fatorial *= numero;
                numero--;
            }
            Console.WriteLine($"O fatorial de {numeroDigitado} é {fatorial}");
        }
    }
}

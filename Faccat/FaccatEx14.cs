using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior, Menor ou Igual a 10");
            Console.WriteLine("Digite um número: ");

            double numero = double.Parse(Console.ReadLine());

            if(numero < 10)
            {
                Console.WriteLine("Menor que 10");
            }
            else if(numero == 10)
            {
                Console.WriteLine("Igual a 10");
            }
            else
            {
                Console.WriteLine("Maior que 10");
            }
        }
    }
}

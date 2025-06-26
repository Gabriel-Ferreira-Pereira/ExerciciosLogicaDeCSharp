using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Positivo ou Negativo");
            Console.WriteLine("Digite um número: ");

            double numero = double.Parse(Console.ReadLine());

            if(numero > -1)
            {
                Console.WriteLine("Número Positivo");
            }
            else
            {
                Console.WriteLine("Número Negativo");
            }
        }
    }
}

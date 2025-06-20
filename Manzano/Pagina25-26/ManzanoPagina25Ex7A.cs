using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano
{
    internal class ManzanoPagina25Ex7A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Celsius para Fahrenheit");

            Console.WriteLine("Digite a temperatura em Celsius: ");

            int celsius = Convert.ToInt32(Console.ReadLine());

            int fahrenheit = (9 *  celsius + 160) / 5;

            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano
{
    internal class ManzanoPagina25Ex7B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit para Celsius");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");

            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            float celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius}");
        }
    }
}

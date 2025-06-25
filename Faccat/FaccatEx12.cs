using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit para Celsius");
            Console.WriteLine("Fahrenheit: ");

            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"Celsius: {celsius}");
        }
    }
}

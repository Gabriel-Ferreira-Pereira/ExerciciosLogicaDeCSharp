using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área do Circulo");
            Console.WriteLine("Digite o valor do raio: ");

            double raio = double.Parse(Console.ReadLine());
            double area = raio * raio * Math.PI;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

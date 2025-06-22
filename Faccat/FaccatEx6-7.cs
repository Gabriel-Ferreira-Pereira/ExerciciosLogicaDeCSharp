using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Àrea do Hexágono");
            Console.WriteLine("Digite o valor de um dos lados: ");

            double lado = double.Parse(Console.ReadLine());
            double area = 3 * Math.Pow(lado, 2) * Math.Sqrt(3) / 2;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

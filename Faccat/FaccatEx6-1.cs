using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área do Retângulo");
            Console.WriteLine("Digite o valor da base: ");

            float valorBase = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura");

            float valorAltura = Convert.ToSingle(Console.ReadLine());
            float area = valorBase * valorAltura;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

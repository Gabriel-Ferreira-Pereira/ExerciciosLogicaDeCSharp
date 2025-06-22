using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área do Trapézio");
            Console.WriteLine("Digite o valor da base maior: ");

            float baseMaior = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da base menor: ");

            float baseMenor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");

            float altura = float.Parse(Console.ReadLine());
            float area = (baseMaior + baseMenor) * altura / 2;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

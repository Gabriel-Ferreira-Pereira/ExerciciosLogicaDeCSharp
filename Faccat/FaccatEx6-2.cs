using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área do Quadrado");
            Console.WriteLine("Digite o valor de um dos lados: ");

            float lado = Convert.ToSingle(Console.ReadLine());
            float area = lado * lado;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx6_5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Àrea do Losango");
            Console.WriteLine("Digite o valor da diagonal maior: ");

            float diagonalMaior = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da diagonal menor: ");

            float diagonalMenor = float.Parse(Console.ReadLine());

            float area = diagonalMaior * diagonalMenor / 2;

            Console.WriteLine($"A área é: {area}");
        }
    }
}

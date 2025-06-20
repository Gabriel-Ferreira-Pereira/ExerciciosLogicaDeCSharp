using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiplicador");

            Console.Write("Digite o primeiro valor: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");

            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 * num2;

            Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}

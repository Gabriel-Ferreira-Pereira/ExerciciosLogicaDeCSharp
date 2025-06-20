using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Divisor");

            Console.Write("Digite o primeiro valor: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");

            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else
            {
                double resultado = (double) num1 / num2;
                Console.WriteLine($"O resultado é: {resultado}");
            }
        }
    }
}

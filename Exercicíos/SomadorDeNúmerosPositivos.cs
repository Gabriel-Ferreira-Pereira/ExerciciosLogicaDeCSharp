using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class SomadorDeNúmerosPositivos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somador de Números Positivos");

            int numero = 0;
            int soma = 0;

            while (numero > -1)
            {
                Console.WriteLine("Digite um número positivo: ");

                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    soma += numero;
                }
                else
                {
                    Console.WriteLine($"A soma dos números é: {soma}");
                }
            }
        }
    }
}

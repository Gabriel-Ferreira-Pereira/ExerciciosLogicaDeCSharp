using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx5_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Antecessor");

            Console.Write("Digite um valor: ");

            int num1 = int.Parse(Console.ReadLine());

            int resultado = num1 - 1;

            Console.WriteLine($"O antecessor do {num1} é o {resultado}");

        }
    }
}

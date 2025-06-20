using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MaiorValorArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior valor de array \n");

            double[] numeros = new double[3];
            int i = 0;

            foreach(double num in numeros)
            {
                Console.WriteLine("Digite um valor: ");

                numeros[i] = Convert.ToDouble(Console.ReadLine());

                i++;
            }

            Console.WriteLine($"\n O maior é: {numeros.Max()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class ContagemRegressiva
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contagem Regressiva");
            Console.WriteLine("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            while(numero > -1)
            {
                Console.WriteLine(numero);

                numero--;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class Tabuada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            int contador = 1;

            Console.WriteLine("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            int multiplicacao;

            while(contador < 11)
            {
                multiplicacao = numero * contador;

                Console.WriteLine($"{numero} X {contador} = {multiplicacao}");

                contador++;
            }
        }
    }
}

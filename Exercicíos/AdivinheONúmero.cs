using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class AdivinheONúmero
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int numeroSecreto = aleatorio.Next(1, 11);

            Console.WriteLine("Adivinhe o Número");
            Console.WriteLine("Digite um número entre 1 e 10");

            int numero = Convert.ToInt32(Console.ReadLine());

            while(numero != numeroSecreto)
            {
                Console.WriteLine("Você errou. Digite outro número");

                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Você acertou");
        }
    }
}

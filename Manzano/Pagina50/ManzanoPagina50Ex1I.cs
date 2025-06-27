using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1I
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior e Menor");

            double maior = 0;
            double menor = 0;

            Console.WriteLine("Digite um número positivo: ");

            double numero = double.Parse(Console.ReadLine());

            if(numero > -1)
            {
                maior = numero;
                menor = numero;
            }

            do
            {
                if (numero > maior)
                {
                    maior = numero;
                }
                else
                {
                    menor = numero;
                }

                Console.WriteLine("Digite outro número positivo: ");
            }while(numero > -1);

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}

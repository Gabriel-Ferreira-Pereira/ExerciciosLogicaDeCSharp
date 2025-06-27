using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1F
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório com Média e Total");

            int soma = 0;
            int contador = 0;
            int media;

            Console.WriteLine("Digite um número positivo: ");

            int numero = int.Parse(Console.ReadLine());

            while(numero > -1)
            {
                soma += numero;
                contador++;

                Console.WriteLine("Digite outro número positivo: ");

                numero = int.Parse(Console.ReadLine());
            }

            if(contador > 0)
            {
                media = soma / contador;

                Console.WriteLine($"A somatória é: {soma}");
                Console.WriteLine($"A média é: {media.ToString("F2")}");
                Console.WriteLine($"O total de números colocados é: {contador}");
            }

            else
            {
                Console.WriteLine("Nenhum número positivo foi colocado");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1H
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olha a Potência");
            Console.WriteLine("Digite um número para a base: ");

            int numeroBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número para o expoente: ");

            int numeroExpoente = int.Parse(Console.ReadLine());
            int potencia = 1;

            for(int contador = 1;  contador <= numeroExpoente; contador++)
            {
                potencia *= numeroBase;
            }
            Console.WriteLine($"{numeroBase} ^ {numeroExpoente} = {potencia}");
        }
    }
}

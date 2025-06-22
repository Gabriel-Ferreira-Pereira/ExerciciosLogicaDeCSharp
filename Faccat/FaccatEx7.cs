using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Idade em dias");
            Console.WriteLine("Digite quantos anos você tem: ");

            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos meses passou do seu último aniversário: ");

            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos dias passou do seu último mêsversário: ");

            int dias = int.Parse(Console.ReadLine());
            int resultado = (ano * 365) + (meses * 30) + dias;

            Console.WriteLine($"Você está vivo a {resultado} dias");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Média Escolar");
            Console.WriteLine("Primeira nota: ");

            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");

            double segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceira nota: ");

            double terceiraNota = double.Parse(Console.ReadLine());
            double notaFinal = (primeiraNota * 2) + (segundaNota * 3) + (terceiraNota * 5);
            double media = notaFinal / 10;

            Console.WriteLine($"Média: {media.ToString("F2")}");
        }
    }
}

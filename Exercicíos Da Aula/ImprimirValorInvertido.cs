using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ImprimirValorInvertido
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inverter");
            Console.WriteLine("Digite uma palavra: ");

            string palavra = Console.ReadLine();
            string invertida = new string(palavra.Reverse().ToArray());

            Console.WriteLine($"\n Invertida: {invertida}");
        }
    }
}

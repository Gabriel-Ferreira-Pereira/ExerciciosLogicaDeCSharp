using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Média pelas Provas");
            Console.WriteLine("Digite a nota da primeira prova: ");

            double primeiraProva = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");

            double segundaProva = double.Parse(Console.ReadLine());
            double media = (primeiraProva +  segundaProva) / 2;

            if(media < 6)
            {
                Console.WriteLine($"{media} = Reprovado");
            }
            else
            {
                Console.WriteLine($"{media} = Aprovado");
            }
        }
    }
}

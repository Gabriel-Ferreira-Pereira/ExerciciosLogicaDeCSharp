using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Preço das Maçãs");
            Console.WriteLine("Digite quantas maçãs você pegou: ");

            int maca = int.Parse(Console.ReadLine());
            int valorFinal;

            if(maca < 12)
            {
                valorFinal = (int)(maca * 1.30F);
            }
            else
            {
                valorFinal = maca * 1;
            }
            Console.WriteLine($"{maca} maçãs vão custar {valorFinal} reais");
        }
    }
}

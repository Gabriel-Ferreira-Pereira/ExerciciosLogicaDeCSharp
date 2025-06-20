using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TabelaMultiplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            int[,] tabuada = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("--- Tabela de Multiplicação (1 a 10) ---");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{tabuada[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}

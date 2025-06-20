using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Digite um número: ");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int multiplicacao = 1;  multiplicacao < 11;  multiplicacao++)
            {
                int res = num * multiplicacao;

                Console.WriteLine($"{num} X {multiplicacao} = {res}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina66
{
    internal class ManzanoPagina66Ex1I
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Série de Fibonacci");

            int termoAnterior = 1;
            int termoAtual = 1;

            Console.WriteLine(termoAnterior);
            Console.WriteLine(termoAtual);

            for(int contador = 3; contador < 16; contador++)
            {
                int proximoTermo = termoAnterior + termoAtual;

                Console.WriteLine(proximoTermo);

                termoAnterior = termoAtual;
                termoAtual = proximoTermo;
            }
        }
    }
}

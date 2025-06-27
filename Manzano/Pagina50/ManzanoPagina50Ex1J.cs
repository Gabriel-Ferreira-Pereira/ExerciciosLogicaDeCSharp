using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1J
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Divisão Inteira");
            Console.WriteLine("Digite o número que será dividido");

            double dividendo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número que irá dividir: ");

            double divisor = double.Parse(Console.ReadLine());
            double quociente;

            if(divisor == 0)
            {
                Console.WriteLine("Não pode dividir 0");
            }
            else
            {
                quociente = 0;

                do
                {
                    dividendo -= divisor;
                    quociente++;
                }while(dividendo >= divisor);

                Console.WriteLine($"O resultado ( quociente ) da divisão é: {quociente}");
            }
        }
    }
}

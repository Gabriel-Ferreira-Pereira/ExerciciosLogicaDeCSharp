using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temporizador");

            Console.WriteLine("Digite as horas desejadas: ");

            int horaDigitada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os minutos desejados: ");

            int minutoDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os segundos desejados: ");

            int segundoDigitado = Convert.ToInt32(Console.ReadLine());

            int minuto, segundo;

            for(int hora = horaDigitada; hora > -1; hora--)
            {
                for(minuto = minutoDigitado; minuto > -1; minuto--)
                {
                    for(segundo = segundoDigitado; segundo > 0; segundo--)
                    {
                        Console.WriteLine($"{hora}h : {minuto}m : {segundo}s");
                    }
                    segundo = 59;
                }
                minuto = 59;
            }
        }
    }
}

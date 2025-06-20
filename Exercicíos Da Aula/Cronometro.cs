using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class Cronometro
    {
        public static void Main(string[] args)
        {
            int hora, segundo, minuto;

            for (hora = 1; hora < 24; hora++)
            {
                for (minuto = 1; minuto < 60; minuto++)
                {
                    for(segundo = 1; segundo < 60; segundo++)
                    {
                        Console.WriteLine($"{hora}h : {minuto}m : {segundo}s");
                    }
                }
            }
        }
    }
}

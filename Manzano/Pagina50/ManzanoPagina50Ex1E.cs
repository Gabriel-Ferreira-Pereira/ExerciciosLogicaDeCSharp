using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1E
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somando Fatorização");

            ulong soma = 0;
            ulong numero;
            ulong fatorial;

            for(int primeiroCOntador = 1; primeiroCOntador < 16; primeiroCOntador++)
            {
                Console.WriteLine($"Digite o {primeiroCOntador}° número: ");

                numero = ulong.Parse( Console.ReadLine() );
                fatorial = 1;

                for(ulong segundoContador = 1; segundoContador <= numero; segundoContador++)
                {
                    fatorial *= segundoContador;
                }

                soma += fatorial;
            }

            Console.WriteLine($"A soma de todos os fatoriais é: {soma}");
        }
    }
}

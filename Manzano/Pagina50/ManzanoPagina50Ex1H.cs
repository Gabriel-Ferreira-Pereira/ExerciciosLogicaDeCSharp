using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Manzano.Pagina50
{
    internal class ManzanoPagina50Ex1H
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área da Casa");

            double areaTotal = 0;
            string nome;
            double largura;
            double comprimento;
            double area;
            string usuario;

            do
            {
                Console.WriteLine("Qual o nome do cômodo: ");

                nome = Console.ReadLine();

                Console.WriteLine("Qual a largura do cômodo: ");

                largura = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o comprimento do cômodo: ");

                comprimento = double.Parse(Console.ReadLine());
                area = largura * comprimento;
                areaTotal = areaTotal + area;


                Console.WriteLine($"A área da {nome} é de: {area.ToString("F2")}");


                Console.WriteLine("Deseja calcular outro cômodo? | Sim | Não |: ");

                usuario = Console.ReadLine();


            }while(usuario == "Sim");

            Console.WriteLine($"A área total ficou em: {areaTotal.ToString("F2")}");
        }
    }
}

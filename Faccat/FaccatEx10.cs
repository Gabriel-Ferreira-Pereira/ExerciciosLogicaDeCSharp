using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Preço Justo");
            Console.WriteLine("Digite quanto custou a fabricação: ");

            double fabricacao = double.Parse(Console.ReadLine());
            double distribuidor = fabricacao * 28 / 100;
            double imposto = fabricacao * 45 / 100;
            double valorFinal = fabricacao + distribuidor + imposto;

            Console.WriteLine($"O melhor preço para o cliente seria: {valorFinal.ToString("F2")}");
        }
    }
}

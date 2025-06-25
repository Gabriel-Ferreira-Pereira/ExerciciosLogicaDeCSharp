using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reajuste Salarial");
            Console.WriteLine("Digite o seu salário atual: ");

            double salario = double.Parse(Console.ReadLine());
            double reajuste = salario / 100 * 6.87;
            double salarioNovo = salario + reajuste;

            Console.WriteLine($"O seu salário passou de {salario} para {salarioNovo.ToString("F2")}");
        }
    }
}

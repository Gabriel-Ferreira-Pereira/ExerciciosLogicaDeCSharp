using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Salário com Comissão e Vendas");
            Console.WriteLine("Digite seu salário: ");

            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da comissão: ");

            double comissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos carros você vendeu: ");

            double carros = double.Parse(Console.ReadLine());
            double vendas = carros * 5 / 100;
            double salarioFinal = salario + comissao + vendas;

            Console.WriteLine($"O salário vai de {salario} para {salarioFinal.ToString("F2")}");
        }
    }
}

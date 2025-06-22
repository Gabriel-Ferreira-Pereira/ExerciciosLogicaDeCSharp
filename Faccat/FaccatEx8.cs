using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FaccatEx8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contador de Votos");
            Console.WriteLine("Digite o número de habitantes: ");

            float habitantes = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de habitantes que foram votar: ");

            float habitantesVotantes = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos: ");

            float validos = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos em branco: ");

            float brancos = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos: ");

            float nulos = float.Parse(Console.ReadLine());
            float foram = (habitantesVotantes / habitantes) * 100;
            float votosValidos = (validos / habitantesVotantes) * 100;
            float votosBrancos = (brancos / habitantesVotantes) * 100;
            float votosNulos = (nulos / habitantesVotantes) * 100;

            Console.WriteLine($"O número de habitantes é: {habitantes}");
            Console.WriteLine($"Os que foram votar são: {habitantesVotantes} que representam {foram.ToString("F2")}");
            Console.WriteLine($"Os votos válidos são: {validos} que representam {votosValidos.ToString("F2")}");
            Console.WriteLine($"Os votos brancos são: {brancos} que representam {votosBrancos.ToString("F2")}");
            Console.WriteLine($"Os votos nulos são: {nulos} que representam {votosNulos.ToString("F2")}");
        }
    }
}

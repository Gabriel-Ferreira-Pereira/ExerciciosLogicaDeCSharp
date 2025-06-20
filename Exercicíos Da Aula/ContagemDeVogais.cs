using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ContagemDeVogais
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Contador de vogal");
            Console.WriteLine("Digite uma frase:");

            string palavraNormal = Console.ReadLine();
            string palavraMinuscula = palavraNormal.ToLower();
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            int contadorVogais = 0;

            foreach (char caractere in palavraMinuscula)
            {
                if (vogais.Contains(caractere))
                {
                    contadorVogais++;
                }
            }
            Console.WriteLine($"A frase digitada foi: {palavraNormal}");
            Console.WriteLine($"O número total de vogais na frase é: {contadorVogais}");
        }
    }
}

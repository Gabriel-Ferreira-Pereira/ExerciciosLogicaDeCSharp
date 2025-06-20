using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Exercicíos
{
    internal class AdivinhaASenha
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adivinhe a Senha");
            Console.WriteLine("A senha tem 6 digitos");

            int senhaOriginal = 729145;

            Console.WriteLine("Digite a senha: ");

            int senha = Convert.ToInt32(Console.ReadLine());

            while(senha != senhaOriginal)
            {
                Console.WriteLine("Você errou. Digite outra senha: ");

                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Você acetou!");
        }
    }
}

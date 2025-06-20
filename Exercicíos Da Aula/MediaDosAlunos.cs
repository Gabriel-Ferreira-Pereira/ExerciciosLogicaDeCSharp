using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MediaDosAlunos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Média dos alunos");

            double[,] notasAlunos = new double[4, 3];
            int numAlunos = notasAlunos.GetLength(0);
            int numProvas = notasAlunos.GetLength(1);

            Console.WriteLine("--- Entrada de Notas dos Alunos ---");

            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine($"\nNotas do Aluno {i + 1}:");

                for (int j = 0; j < numProvas; j++)
                {
                    bool entradaValida = false;
                    while (!entradaValida)
                    {
                        Console.Write($"  Digite a nota da Prova {j + 1}: ");
                        string entrada = Console.ReadLine();

                        if (double.TryParse(entrada, out notasAlunos[i, j]))
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a nota.");
                        }
                    }
                }
            }
            Console.WriteLine("\n--- Relatório de Médias ---");
            Console.WriteLine("\n-- Média de Cada Aluno --");

            for (int i = 0; i < numAlunos; i++)
            {
                double somaNotasAluno = 0;
                for (int j = 0; j < numProvas; j++)
                {
                    somaNotasAluno += notasAlunos[i, j];
                }
                double mediaAluno = somaNotasAluno / numProvas;

                Console.WriteLine($"Média do Aluno {i + 1}: {mediaAluno:F2}");
            }
            Console.WriteLine("\n-- Média de Cada Prova --");

            for (int j = 0; j < numProvas; j++)
            {
                double somaNotasProva = 0;
                for (int i = 0; i < numAlunos; i++)
                {
                    somaNotasProva += notasAlunos[i, j];
                }
                double mediaProva = somaNotasProva / numAlunos;

                Console.WriteLine($"Média da Prova {j + 1}: {mediaProva:F2}");
            }
            Console.WriteLine("\n--- Fim do Programa ---");

        }
    }
}

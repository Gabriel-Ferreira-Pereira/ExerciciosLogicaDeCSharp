namespace ExerciciosLogica.Manzano
{
    internal class ManzanoPagina25Ex7C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Volume de Óleo");

            Console.WriteLine("Qual é a altura da lata?: ");

            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é o raio da circuferência da lata?: ");

            int raio = Convert.ToInt32(Console.ReadLine());

            double volume = Math.PI *  Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume da lata é: {volume}");
        }
    }
}

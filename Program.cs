using System;

namespace RankingDesafios
{
    class Program
    {
        static void Main(string[] args)
        {

            string respostaReal = "";

            Console.WriteLine("Digite dois valores!");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            string respostaIdeal = A + " + " + B + " = " + (A + B);

            Console.WriteLine("Agora irei somar os valores");
            respostaReal = A + " + " + B + " = " + (A + B);
            Console.WriteLine(respostaReal);

            if (respostaIdeal == respostaReal)
            {
                Console.WriteLine("Parabéns, você resolveu o dessafio!");
            }
            else
            {
                Console.WriteLine("Que pena, você não conseguiu resolver o desafio.");                
            }
        }
    }
}

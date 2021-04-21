using System;

namespace Coordenadas
{
    class Program
    {
        //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
        //A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 valores com uma casa decimal para (x)");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 valores com uma casa decimal para (y)");
            double y = double.Parse(Console.ReadLine());

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
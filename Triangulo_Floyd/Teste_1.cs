using System;

namespace Triangulo_Floyd
{
    class Teste_1
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Digite um número:");
            int quant_degraus = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int i, j = 1;

            for (i = 1; i <= quant_degraus; i++)
            {
                for (j = 1; j < (i + 1); j++)
                {
                    Console.Write("*" +" ");
                }

                Console.Write("\n");    
            }

            Console.ReadLine();
        }
    }
}

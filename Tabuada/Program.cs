using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formatação
            Console.WriteLine("\n---------- TABUADA ----------\n");
            // Cria a Variável Resultado
            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * 1;
                Console.WriteLine("O Resultado de " + i + " x 1"+ " = " + resultado);
                resultado = i * 2;
                Console.WriteLine("O Resultado de " + i + " x 2"+ " = " + resultado);
                resultado = i * 3;
                Console.WriteLine("O Resultado de " + i + " x 3" + " = " + resultado);
                resultado = i * 4;
                Console.WriteLine("O Resultado de " + i + " x 4" + " = " + resultado);
                resultado = i * 5;
                Console.WriteLine("O Resultado de " + i + " x 5" + " = " + resultado);
                resultado = i * 6;
                Console.WriteLine("O Resultado de " + i + " x 6" + " = " + resultado);
                resultado = i * 7;
                Console.WriteLine("O Resultado de " + i + " x 7" + " = " + resultado);
                resultado = i * 8;
                Console.WriteLine("O Resultado de " + i + " x 8" + " = " + resultado);
                resultado = i * 9;
                Console.WriteLine("O Resultado de " + i + " x 9" + " = " + resultado);
                resultado = i * 10;
                Console.WriteLine("O Resultado de " + i + " x 10" + " = "  + resultado + "\n");
            }
            Console.WriteLine("\n---------- FIM ----------\n");        }
    }
}

